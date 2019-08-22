using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReportScript : MonoBehaviour
{
    
    public void NotNow()
    {
        MainScript.self.fonReport.SetActive(false);
    }

    public void Report()
    {
        if (StarScript.self.stars>2)
        {
#if UNITY_ANDROID
            PlayerPrefs.SetInt(MainScript.self.send,1);
            Application.OpenURL("https://play.google.com/store/apps/details?id=com.natalymobileprojects.threecards");
            MainScript.self.fonReport.SetActive(false);
            Debug.Log("Статус "+PlayerPrefs.GetInt(MainScript.self.send));
#endif

#if UNITY_IOS
            PlayerPrefs.SetInt(MainScript.self.send,1);
            Application.OpenURL("https://apps.apple.com/ru/app//id1457592947");
            MainScript.self.fonReport.SetActive(false);
#endif

        }
        else
        {
            PlayerPrefs.SetInt(MainScript.self.send, 0);
            MainScript.self.fonReport.SetActive(false);
        }
    }
}
