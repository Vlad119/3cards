using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBTN : MonoBehaviour
{
  //  public GameObject burger_btn;

    public void Menu_btn()
    { MainScript.self.fon_menu.SetActive(true);
      MainScript.self.fon_menu.GetComponent<Animator>().SetTrigger("open");
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
