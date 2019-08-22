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

public class CheckScript : MonoBehaviour {
    public int count;
    public static CheckScript self;
    public Text choise_i_cards;
    public int cardcount=3;



    // Use this for initialization
    void Start ()
    {
        if (!self) self = this;
        else Destroy(gameObject);
        PlayerPrefs.SetInt("prog", 2);
        choise_i_cards.text= "Выберите " + CheckScript.self.cardcount + " любые карты";
}


	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
