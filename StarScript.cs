using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour
{
    public static StarScript self;
    public GameObject s1on;
    public GameObject s2on;
    public GameObject s3on;
    public GameObject s4on;
    public GameObject s5on;

    public GameObject s1off;
    public GameObject s2off;
    public GameObject s3off;
    public GameObject s4off;
    public GameObject s5off;

    public int stars;

    public void Start()
    {
        if (self != this)
        { self = this; }
        else Destroy(gameObject);
    }

    public void AllClose()
    {
        stars = 0;
        s1on.SetActive(false);
        s2on.SetActive(false);
        s3on.SetActive(false);
        s4on.SetActive(false);
        s5on.SetActive(false);
    }

    public void ChangeStar1()
    {
        AllClose();
        {
            stars = 1;
            s1on.SetActive(true);
        }
    }

    public void ChangeStar2()
    {
        AllClose();
        {
            stars = 2;
            s1on.SetActive(true);
            s2on.SetActive(true);
        }
    }

    public void ChangeStar3()
    {
        AllClose();
        {
            stars = 3;
            s1on.SetActive(true);
            s2on.SetActive(true);
            s3on.SetActive(true);
        }
    }

    public void ChangeStar4()
    {
        AllClose();
        {
            stars = 4;
            s1on.SetActive(true);
            s2on.SetActive(true);
            s3on.SetActive(true);
            s4on.SetActive(true);
        }
    }

    public void ChangeStar5()
    {
        AllClose();
        {
            stars = 5;
            s1on.SetActive(true);
            s2on.SetActive(true);
            s3on.SetActive(true);
            s4on.SetActive(true);
            s5on.SetActive(true);
        }
    }



}
