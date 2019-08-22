using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextBTN1 : MonoBehaviour
{


    public void Next1()
    {

        MainScript.self.fon_rules.SetActive(false);
        MainScript.self.fon_rules2.SetActive(true);
    }

    public void Next2()
    {
        MainScript.self.fon_rules2.SetActive(false);
        MainScript.self.fon_game.SetActive(true);
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
