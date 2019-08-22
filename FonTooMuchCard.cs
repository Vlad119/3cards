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
using GoogleMobileAds;
using GoogleMobileAds.Api;


public class FonTooMuchCard : MonoBehaviour {
    public List<Cards> cards;
    public static FonTooMuchCard self;
    public GameObject content;


    private void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-8142240178040183/9288188771";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-8142240178040183/1541560698";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
       MainScript.self.interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().AddTestDevice("CAEFBEA8A22A6FF3829FC96E1660EE3F").Build();
        // Load the interstitial with the request.

        MainScript.self.interstitial.LoadAd(request);
    }




    private void OnEnable()
    {

        if (
            PlayerPrefs.GetInt("noads") != 1)
        {
            RequestInterstitial();
        }

    }





    // Use this for initialization
    void Start ()
    {
        if (self != this)
            self = this;
        else Destroy(gameObject);

        float y = Screen.height;
        float x = Screen.width;

        Debug.Log(Screen.height+"!!!!"+Screen.width);

//        if ((Screen.height==2048)&&(Screen.width==1536)) 
  //      content.GetComponent<GridLayoutGroup>().cellSize=new Vector2(180,205);

        ///        if ((Screen.height == 1920) && (Screen.width == 1080))
        //         content.GetComponent<GridLayoutGroup>().cellSize = new Vector2(150, 205);

        //        if ((Screen.height == 2560) && (Screen.width == 1440))
        //          content.GetComponent<GridLayoutGroup>().cellSize = new Vector2(150, 205);
        //          content.GetComponent<GridLayoutGroup>().cellSize = new Vector2(150, 205);


        if (y / x > 1.32 && y / x < 1.34)
        {
            //          content.GetComponent<GridLayoutGroup>().cellSize = new Vector2(x / 8, x / 8 * 1.37f);
            content.GetComponent<GridLayoutGroup>().spacing = new Vector2(x / 30, 5);
        }


        if (y / x >1.76 && y/x <1.78)
        {
  //          content.GetComponent<GridLayoutGroup>().cellSize = new Vector2(x / 8, x / 8 * 1.37f);
           content.GetComponent<GridLayoutGroup>().spacing = new Vector2(x/72, 5);
        }
        
        //iPhon XMAX
        if (y / x > 2.15 && y / x < 2.17)
        {
            //          content.GetComponent<GridLayoutGroup>().cellSize = new Vector2(x / 8, x / 8 * 1.37f);
            content.GetComponent<GridLayoutGroup>().spacing = new Vector2(0, 5);
        }


        //планшеты  - 6*6 карт
        if (y/x==1.6 ) {
            //            content.GetComponent<GridLayoutGroup>().cellSize = new Vector2(x/8 , x /8 * 1.37f);
            content.GetComponent<GridLayoutGroup>().spacing = new Vector2(x / 48, 5);
        }
        if (y / x <2.1 && y/x > 1.9)
        {
            //            content.GetComponent<GridLayoutGroup>().cellSize = new Vector2(x/8 , x /8 * 1.37f);
            content.GetComponent<GridLayoutGroup>().spacing = new Vector2(0, y/60);
        }

    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
