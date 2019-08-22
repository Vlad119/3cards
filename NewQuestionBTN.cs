using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Net;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using System.Xml;
using System.IO;


    public class NewQuestionBTN : MonoBehaviour {

    public GameObject question_btn;
    public int load=0;

    public static NewQuestionBTN self;


    public void NewQuestion()

    {
        PlayerPrefs.SetInt("load", 9);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        MainScript.self.fon_preview.SetActive(false);
    }
    
	// Use this for initialization
	void Start ()
    {
        if (!self)
        {
            self = this;
        }
        Destroy(gameObject);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
