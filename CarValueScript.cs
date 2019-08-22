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

    public class CarValueScript : MonoBehaviour {
    public static CarValueScript self;
    public int index;
    public GameObject card_image;
    public GameObject title;
    public GameObject info;

    // Use this for initialization
    void Start ()
    {
        if (self != this)
        self = this;
        else Destroy(gameObject);           
    }
    
    private void OnEnable()
    {
        card_image.GetComponent<Image>().sprite = FonTooMuchCard.self.cards[index].card_image;
        title.GetComponent <Text>().text = FonTooMuchCard.self.cards[index].title;
        info.GetComponent<Text>().text = FonTooMuchCard.self.cards[index].info;
    }
    // Update is called once per frame
    void Update ()
    {
    
    }
}
