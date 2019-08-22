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
public class DragDownScript : MonoBehaviour {

    public GameObject cube2;
    public GameObject cube21;
    public GameObject cube22;
    public GameObject cube23;
    public Vector3 start_position;
    public Vector3 end_position;

    public void OnMouseDown()
    {
        start_position = Input.mousePosition;
        
    }
    public void OnMouseUp()
    {
        end_position = Input.mousePosition;
        
        Swipe();
    }

    public void Swipe()
    {
        Debug.Log(start_position);
        Debug.Log(end_position);
        if (end_position.y < start_position.y)
        {
            cube2.GetComponent<Animator>().Play("ii");
            cube2.GetComponent<Animator>().Play("dragdown");
            cube21.GetComponent<Animator>().Play("cascade");
            cube22.GetComponent<Animator>().Play("cascade1");
            cube23.GetComponent<Animator>().Play("cascade2");
        }
    } 

    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
