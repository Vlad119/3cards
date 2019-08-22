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

[Serializable]
public class Messages
{
    public int number;
    public string value;
}


[Serializable]
public class Cards
{
    public Sprite card_image;
    public string title;
    public string info;
}



public class MainScript : MonoBehaviour
{
    public GameObject fon_preview;
    public GameObject ads;
    public GameObject ads_restore;
    public GameObject fon_rules;
    public GameObject fon_rules2;
    public GameObject fon_game;
    public GameObject fon_too_much_cards;
    public GameObject fon_menu;
    public GameObject fon_card_value;
    public GameObject fonReport;

    public static MainScript self;
    public Canvas canvas;
    public List<Cards> cards;
    public string[] messages;
    public bool swiping;
    public BannerView bannerView;
    int launches = 0;
    string launch = "nn";
    string yesterday = "qq";
    int differentDay = 0;
    string differentDays = "vv";
    public string send = "qwe";

    public bool ads_debug = true;


    int needHours;
    int needSeconds;
    int allSeconds;
    public InterstitialAd interstitial;


    void Start()
    {
        //  PlayerPrefs.DeleteAll();
        self = this;

        Stop();

        int h = DateTime.Now.Hour;
        int minutes = DateTime.Now.Minute;

        if (h > 12)
        {
            needHours = h - 12;
            minutes = 60 - minutes;
            needSeconds = needHours * 60 * 60 - minutes*60;
            allSeconds = (needSeconds + 172800)*1000;
        }
        else
        {
            needHours = 12 - h;
            minutes = 60 - minutes;
            needSeconds = needHours * 60 * 60 + minutes * 60;
            allSeconds = (needSeconds + 172800)*1000;
        }


        Repeating();



        Debug.Log("Если оценка была отправлена, то статус равен 1. Статус сейчас: " + PlayerPrefs.GetInt(send));
        if (PlayerPrefs.GetInt(send) != 1)
        {

            Debug.Log("Сохранённая дата " + PlayerPrefs.GetInt(yesterday));
            Debug.Log("Текущая дата " + DateTime.Now.Day.ToString());

            if (PlayerPrefs.GetInt(yesterday) != DateTime.Now.Day)
            {
                Debug.Log("Разные дни");
                PlayerPrefs.SetInt(yesterday, DateTime.Now.Day);
                differentDay = PlayerPrefs.GetInt(differentDays) + 1;
                PlayerPrefs.SetInt(differentDays, differentDay);
            }
            launches = PlayerPrefs.GetInt(launch) + 1;
            PlayerPrefs.SetInt(launch, launches);
            Debug.Log("запусков " + launches);
            Debug.Log("количество разных дней " + PlayerPrefs.GetInt(differentDays));
            if (PlayerPrefs.GetInt(launch) > 10 && PlayerPrefs.GetInt(differentDays) >= 2)
            {
                fonReport.SetActive(true);
                launches = 0;
                PlayerPrefs.SetInt(launch, launches);
                differentDay = 0;
                PlayerPrefs.SetInt(differentDays, differentDay);
            }
        }







#if UNITY_ANDROID
        MainScript.self.ads_restore.SetActive(false);
#endif

        if (
            PlayerPrefs.GetInt("noads") != 1 )
        {

            

            


#if UNITY_ANDROID
            string appId = "ca-app-pub-8142240178040183~5813951070";
#elif UNITY_IOS
        string appId = "ca-app-pub-8142240178040183~1693112351";
#else
            string appId = "unexpected_platform";
#endif


            // Initialize the Google Mobile Ads SDK.
            MobileAds.Initialize(appId);
            RequestBanner();
            

        }
        else
        {
            if (MainScript.self.bannerView != null) MainScript.self.bannerView.Destroy();
            MainScript.self.ads.SetActive(false);
            MainScript.self.ads_restore.SetActive(false);
            Debug.Log("NO ADS");
        }
        fon_game.SetActive(true);
        for (int i = 0; i < 35; i++)
        {
            var mem = cards[i];
            int m = (int)UnityEngine.Random.Range(0, 35);
            cards[i] = cards[m];
            cards[m] = mem;
        }
    }

    private void RequestBanner()
    {

#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-8142240178040183/7869623993";
#elif UNITY_IOS
        string adUnitId = "ca-app-pub-8142240178040183/2739790082";
#else
            string adUnitId = "unexpected_platform";
#endif

        //adUnitId = "ca-app-pub-3940256099942544/6300978111"; //test
        // Create a 320x50 banner at the top of the screen.
        bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);
        // Create an empty ad request
            AdRequest request = new AdRequest.Builder().AddTestDevice("CAEFBEA8A22A6FF3829FC96E1660EE3F").Build();
        // Load the banner with the request.
        bannerView.LoadAd(request);
    }
    // Update is called once per frame

    public void Repeating()
    {
        string mes = messages[UnityEngine.Random.Range(0, 11)];
        LocalNotification.SendRepeatingNotification(1, allSeconds, allSeconds, " ", mes, new Color32(0xff, 0xff, 0xff, 255), bigIcon: "app_icon");
        Debug.Log("Запуск Repeat");
        Debug.Log(messages[UnityEngine.Random.Range(0, 29)]);
        Debug.Log("Оповещене сработает через: " + allSeconds/1000 / 60 / 60 / 24 + " дня или " + allSeconds /1000/ 60 / 60 + " часов или " +allSeconds/1000/60+" минут или "+ allSeconds/1000 + " секунд");
    }

    public void Stop()
    {
        LocalNotification.CancelNotification(1);
    }



  
}