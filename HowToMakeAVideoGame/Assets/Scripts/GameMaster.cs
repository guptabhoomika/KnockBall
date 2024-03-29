﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameMaster : MonoBehaviour
{
    public GameObject settingPannel;
    public GameObject infoPannel;
    public  bool isActiveSetting;
    public bool isActiveInfo;
    public string sceneName;
    string subject = "ShareURL";
    string body = "Hey!I fond this really awesome game called KNOCK BALL.TRY IT OUT!!!";

    public void play()
    {
        SceneManager.LoadScene(sceneName);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    public void OpenUrl()
    {
        Application.OpenURL(@"googlechrome://google.com");
        Debug.Log("URl");
    }
    public void setting()
    {
        if(settingPannel!=null)
        {

            settingPannel.SetActive(!isActiveSetting);
            isActiveSetting = !isActiveSetting;
           
        }
       

    }
    public void info()
    {
        if(infoPannel!= null)
        {
            infoPannel.SetActive(!isActiveInfo);
            isActiveInfo = !isActiveInfo;
        }
    }
   


    public void OnAndroidTextSharingClick()
    {

        StartCoroutine(ShareAndroidText());
        Debug.Log("Share");

    }
    IEnumerator ShareAndroidText()
    {
        yield return new WaitForEndOfFrame();
        //execute the below lines if being run on a Android device

        //Reference of AndroidJavaClass class for intent
        AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");
        //Reference of AndroidJavaObject class for intent
        AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");
        //call setAction method of the Intent object created
        intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));
        //set the type of sharing that is happening
        intentObject.Call<AndroidJavaObject>("setType", "text/plain");
        //add data to be passed to the other activity i.e., the data to be sent
        intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), subject);
        //intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TITLE"), "Text Sharing ");
        intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), body);
        //get the current activity
        AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");
        //start the activity by sending the intent data
        AndroidJavaObject jChooser = intentClass.CallStatic<AndroidJavaObject>("createChooser", intentObject, "Share Via");
        currentActivity.Call("startActivity", jChooser);

    }

}
