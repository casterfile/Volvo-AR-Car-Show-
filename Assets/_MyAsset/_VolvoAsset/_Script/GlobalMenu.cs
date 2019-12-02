using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalMenu : MonoBehaviour {
    public GameObject GlobalMenuDialog;
	// Use this for initialization
	void Start () {
        GlobalMenuDialog.SetActive(false);

    }

    public void HideMenu()
    {
        GlobalMenuDialog.SetActive(false);

    }

    // Update is called once per frame
    public void GoHome () {
        SceneManager.LoadScene("Scene_0_Detailer");
    }
    public void GoTestDrive()
    {
        SceneManager.LoadScene("Scene_0_Intro");
    }

    public void GoQuotes()
    {
        SceneManager.LoadScene("Scene_2_quotes");
    }
}
