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

public class LeftScript : MonoBehaviour
{
    public GameObject cube;
    public LeftScript nextCard;
    public Text card_switch_txt;
    public Text card_switch_txt2;
    public GameObject card_part_txt;
    private Vector3 start_position;
    private Vector3 end_position;
    public GameObject fon_too_much_cards;
    [SerializeField] private bool down = false;



    public void OnMouseDown()
    {
        start_position = Input.mousePosition;
        Debug.Log(start_position);

    }
    public void OnMouseUp()
    {
        end_position = Input.mousePosition;
        Debug.Log(end_position);
        if (Mathf.Abs(end_position.x - start_position.x) >= Mathf.Abs(end_position.y - start_position.y)
        && (end_position - start_position).magnitude > 1)
        {
            if (end_position.x < start_position.x)
            {
                StartCoroutine (SwipeLeft());
            }
        }
        else
        {
            if (end_position.y < start_position.y)
            {
                SwipeDown();
            }
        }
    }

    IEnumerator SwipeLeft()
    {
        if (!down && !MainScript.self.swiping)
        {
            MainScript.self.swiping = true;
            if ((Fon_game.self.number - 1) == 4 || (Fon_game.self.number - 1) == 3 || (Fon_game.self.number - 1) == 2)
            {
                card_switch_txt.text = "Перетасуйте карты " + (Fon_game.self.number - 1) + " раза";
            }
            else
            {
                card_switch_txt.text = "Перетасуйте карты " + (Fon_game.self.number - 1) + " раз";
            }

            card_switch_txt2.text = "(смахните справа налево пальцем по экрану)";
            cube.GetComponent<Animator>().SetTrigger("left");
            yield return new WaitForSecondsRealtime(0.5f);
            MainScript.self.swiping = false;
        }
    }

    public void SwipeDown()
    {
        GetComponent<Animator>().enabled = true;
        if (down)
        cube.GetComponent<Animator>().SetTrigger("down");

    }

    public void cll()
    {
        GetComponent<Animator>().enabled = false;
        GetComponent<RectTransform>().localPosition += new Vector3(0, 0, Fon_game.self.number); 
        down = true;

        Fon_game.self.Decrement();
    }

    public void BottomDrag()
    {       
            if (nextCard)
            {
                nextCard.down = true;
                nextCard.SwipeBottom();
            }
            else
            {
                MainScript.self.fon_game.SetActive(false);
                MainScript.self.fon_too_much_cards.SetActive(true);

                //переход на следующий фон
            }
    }

    public void SwipeBottom()
    {
        GetComponent<Animator>().enabled = true;
        if (down)
        cube.GetComponent<Animator>().SetTrigger("bottomdrag");

    }


    public void NextCardDown()
    {
        if (nextCard)
        {
            nextCard.down = true;
            nextCard.SwipeDown();
        }
        else {
            MainScript.self.fon_game.SetActive(false);
            MainScript.self.fon_too_much_cards.SetActive(true); 
            
            //переход на следующий фон
        }
    }

    // Use this for initialization
    void Start()
    {
        card_switch_txt.text = "Перетасуйте карты 9 раз";
        card_switch_txt2.text = "(смахните справа налево пальцем по экрану)";

    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
