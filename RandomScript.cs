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

using Random = UnityEngine.Random;//это не я придумал

public class RandomScript : MonoBehaviour
{

    public GameObject card;
    public int rnd ;

    public void RandomCard()
    {
        Random rand = new Random();
        int temp;
      //  temp = rand.Next(36);
    }
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
