using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinAdder : MonoBehaviour
{
    private int count;
    public Text coinText;
    public Rigidbody rb;
    public AudioSource coinAudio;
    private void Start()
    {
        count = 0;
        coinText.text = "0";
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            other.gameObject.SetActive(false);
            count++;
            
            SetText(count);


        }

    }
    void SetText(int count)
    {
        coinText.text = count.ToString();
        coinAudio.Play();

    }
}
