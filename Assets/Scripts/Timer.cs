using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Timer : MonoBehaviour
{
    public float countdown = 30;
    public Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (countdown > 0)
        {
            countdown -= Time.deltaTime;
        }
        text.text = countdown.ToString("F2");

        if (countdown < 0)
        {
            SceneManager.LoadScene("menu");
            
        }
    }
}
