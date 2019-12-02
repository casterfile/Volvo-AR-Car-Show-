using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolvoCanvas : MonoBehaviour {
    public GameObject POPMenu;
	// Use this for initialization
	void Start () {
        POPMenu.SetActive(false);
	}
	
	// Update is called once per frame
	public void PauseMenuShow() {
        POPMenu.SetActive(true);
    }

    public void PauseMenuShowResume()
    {
        print("Resume");
        POPMenu.SetActive(false);
    }

    public void PauseMenuShowEndTestDrive()
    {
        print("EndTestDrive");
        SceneManager.LoadScene("Scene_0_Intro");
    }

    public void PauseMenuShowGetAQuote()
    {
        print("GetAQuote");
        SceneManager.LoadScene("Scene_2_quotes");
    }

}
