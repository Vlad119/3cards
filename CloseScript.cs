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

public class CloseScript : MonoBehaviour {
    public GameObject close_btn;
    public GameObject main;
    private Vector3 start_position;
    private Vector3 end_position;

    public void OnMouseDown()
    {
        start_position = Input.mousePosition;
        Debug.Log(start_position);
    }
    public void OnMouseUp()
    {
        end_position = Input.mousePosition;
        Debug.Log(end_position);
    }

    public void Close()
    {

        if (end_position.y < start_position.y)
        {
            MainScript.self.fon_menu.GetComponent<Animator>().SetTrigger("close");
        }
    }
    public void CloseMenu()
    {
        MainScript.self.fon_menu.GetComponent<Animator>().SetTrigger("close");
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
