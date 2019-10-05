using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class audioManager : MonoBehaviour


{
    public GameObject audioButton;
    
    public Sprite audioOn;
    public Sprite audioOff;
   
    // Start is called before the first frame update
    void Start()
    {
        if(AudioListener.pause == true)
        {
            audioButton.GetComponent<Image>().sprite = audioOff;
        }
        else
        {
            audioButton.GetComponent<Image>().sprite = audioOn;
        }
        
    }

  public  void SoundControl()
  { 
        if(AudioListener.pause == true)
        {
            AudioListener.pause = false;
            audioButton.GetComponent<Image>().sprite = audioOn;


        }
        else
        {
            AudioListener.pause =true;
            audioButton.GetComponent<Image>().sprite = audioOff;
        }
    }
    
}
