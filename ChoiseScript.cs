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

public class ChoiseScript : MonoBehaviour
{
    public GameObject question_btn;
    public GameObject about_btn;
    public GameObject rules_btn;
    public GameObject disable_ads_btn;
    public GameObject back_btn;

    public void Game()

    {
        AllClose();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        if (PlayerPrefs.GetInt("noads") == 1)
        {
            MainScript.self.bannerView.Destroy();
            MainScript.self.ads.SetActive(false);
            MainScript.self.ads_restore.SetActive(false);
            Debug.Log("NO ADS");
        }
    }

    public void About()

    {
        AllClose();
        MainScript.self.fon_rules.SetActive(true);
    }

    public void Rules()

    {
        AllClose();
        MainScript.self.fon_rules2.SetActive(true);
    }

    public void Back()

    {
        AllClose();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Diactivate()

    {

    }

    public void AllClose()
    {
        MainScript.self.fon_card_value.SetActive(false);
        MainScript.self.fon_game.SetActive(false);
        MainScript.self.fon_menu.SetActive(false);
        MainScript.self.fon_preview.SetActive(false);
        MainScript.self.fon_rules.SetActive(false);
        MainScript.self.fon_rules2.SetActive(false);
        MainScript.self.fon_too_much_cards.SetActive(false);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
