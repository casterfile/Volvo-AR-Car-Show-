using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolvoIntroCanvas : MonoBehaviour {
    public GameObject Slide1, Slide2, Slide3;
    private int CountSlide = 0;
    // Use this for initialization
    void Start () {
        CountSlide = 0;
        Slide1.SetActive(true);
        Slide2.SetActive(false);
        Slide3.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (CountSlide == 0)
        {
            Slide1.SetActive(true);
            Slide2.SetActive(false);
            Slide3.SetActive(false);
        }
        else if(CountSlide == 1)
        {
            Slide1.SetActive(false);
            Slide2.SetActive(true);
            Slide3.SetActive(false);
        }
        else if (CountSlide == 2)
        {
            Slide1.SetActive(false);
            Slide2.SetActive(false);
            Slide3.SetActive(true);
        }
	}

    public void StartCar()
    {
        SceneManager.LoadScene("Scene_1_SceneGame");
    }



    public void Next()
    {
        CountSlide++;
        if (CountSlide >= 3)
        {
            CountSlide = 0;
        }
    }

    public void Prev()
    {
        CountSlide--;
        if (CountSlide <= -1)
        {
            CountSlide = 2;
        }
    }
}
