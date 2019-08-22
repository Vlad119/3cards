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

public class TurnScript : MonoBehaviour
{
    public GameObject card;
    public int index;
    public MeshRenderer mesh;
    bool b = false;
    private float timeRemaining = 1.8f;


    public void TurnCard()
    {
        {
            if (!b)
            {
                b = true;
                if (FonTooMuchCard.self.cards.Count < 3)
                {
                    card.GetComponent<Animator>().SetTrigger("turnCard");
                    CheckScript.self.count++;
                    CheckScript.self.cardcount--;
                    mesh.material = new Material(mesh.material);
                    mesh.material.SetTexture("_MainTex", MainScript.self.cards[index].card_image.texture);
                    FonTooMuchCard.self.cards.Add(MainScript.self.cards[index]);
                }
            }
        }
        
    }

    public void Check()
    {

        if (CheckScript.self.cardcount > 1)
            CheckScript.self.choise_i_cards.text = "Выберите " + CheckScript.self.cardcount + " любые карты";

        else if (CheckScript.self.cardcount == 1)
            CheckScript.self.choise_i_cards.text = "Выберите " + CheckScript.self.cardcount + " любую карту";
        else
        {
            CheckScript.self.choise_i_cards.text = "";
         //MainScript.self.fon_too_much_cards.SetActive(false);
         //   MainScript.self.fon_card_value.SetActive(true);
        }
    }



    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckScript.self.cardcount == 0)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining < 0)
            {
                MainScript.self.fon_too_much_cards.SetActive(false);
                MainScript.self.fon_card_value.SetActive(true);
            }
        }
    }
}
