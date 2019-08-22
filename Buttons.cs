using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.Events;


public class Buttons : MonoBehaviour, IPointerClickHandler
{
    private bool scboll;
    private bool flagsc;
    public UnityEvent PressButtonInvoke;
    private Vector3 StartScale, TargetScale;
    const int spsc = 5;

    void Start()
    {
        StartScale = gameObject.transform.localScale;
        TargetScale = new Vector3(StartScale.x * 1.05f, StartScale.y * 1.05f, StartScale.z);
        flagsc = false;

    }
    void Update()
    {
        if (scboll == true)
        {
            switch (flagsc)
            {
                case true:
                    gameObject.transform.localScale -= new Vector3(Time.deltaTime * spsc, Time.deltaTime * spsc, Time.deltaTime * spsc);
                    break;
                case false:
                    gameObject.transform.localScale += new Vector3(Time.deltaTime * spsc, Time.deltaTime * spsc, Time.deltaTime * spsc);
                    break;
            }
            if (gameObject.transform.localScale.x > TargetScale.x) flagsc = true;
            if (gameObject.transform.localScale.x <= StartScale.x)
            {
                flagsc = false;
                scboll = false;
                gameObject.transform.localScale = StartScale;
            }
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        scboll = true;
        StartCoroutine(ClikContinue());

    }

    
    IEnumerator ClikContinue()
    {
        while (scboll == true)
        {
            yield return null;
        }

        PressButtonInvoke.Invoke();
    }

    public void OnMouseExit()
    {
        if (gameObject.GetComponent<Image>())
            gameObject.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
    }
    public void OnMouseOver()
    {
        if (gameObject.GetComponent<Image>())
            gameObject.GetComponent<Image>().color = new Color(0.8f, 0.8f, 0.8f, 1f);
    }

}



