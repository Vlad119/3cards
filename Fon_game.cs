using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;

public class Fon_game : MonoBehaviour {
    public static Fon_game self;
    public int number;
    private int m_number;
    public Text card_switch_txt;
    public Text card_switch_txt2;
    public Text card_part_txt;
    [SerializeField] private GameObject beginCard;
    private InterstitialAd interstitial;
    public int c;
    // Use this for initialization
    void Start ()
    {
        if (!self) self = this;
        else Destroy(gameObject);
        PlayerPrefs.SetInt("prog",1);
        m_number = number;
        c = 0;
    }










public void Decrement()
    {
        
        number--;
        Debug.Log("number" + number);
        if (number == 0)
        {
            card_switch_txt.text = "";
            card_switch_txt2.text = "";
            card_part_txt.gameObject.SetActive(true); 
            beginCard.GetComponent<RectTransform>().localPosition -= new Vector3(0,0, m_number);         
        }
    }

	// Update is called once per frame
	void Update () {

    }
}
