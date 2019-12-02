using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuotesCalculation : MonoBehaviour {
    public GameObject Slide01, Slide02;
    // Use this for initialization
    void Start () {
        Slide01.SetActive(true);
        Slide02.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void EQuotesNext()
    {
        Slide01.SetActive(false);
        Slide02.SetActive(true);
    }

    public void EQuotesSubmit()
    {
        SceneManager.LoadScene("Scene_0_Detailer");
    }
}
