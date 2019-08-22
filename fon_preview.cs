using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fon_preview : MonoBehaviour
{ 
    public static fon_preview self;
    public float timeRemaining = 1f;
    // Use this for initialization
    void Start()
    {
        if (!self)
        {
            self = this;
        }
        else Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    { 
        {
            if (timeRemaining > 0)
            {
                //  Debug.Log("Waitting..." + timeRemaining);
                timeRemaining -= Time.deltaTime;
                if (timeRemaining < 0)
                {
                    MainScript.self.fon_preview.SetActive(false);
                    if (PlayerPrefs.GetInt("learn",0) == 0)
                    {
                        PlayerPrefs.SetInt("learn", 1);
                        MainScript.self.fon_rules.SetActive(true);
                    }
                    //Debug.Log("переход");
                }
            }
       

            
        }
    }
}
