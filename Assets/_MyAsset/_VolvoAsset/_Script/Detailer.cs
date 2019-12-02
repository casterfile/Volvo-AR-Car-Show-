using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Detailer : MonoBehaviour {
    public GameObject Slide01, Slide02, Slide03, Slide04, Slide05, Slide06, Slide07, Slide08, btnSlide4MenuList, Slide5Car1, Slide5Car2, Slide6Car1, Slide6Car2;
    private int CountSlide = 0, CarOneOrTwo = 1;

    public GameObject GlobalMenuDialog;
    // Use this for initialization
    void Start () {
        CarOneOrTwo = 1;
        CountSlide = 0;
        RemoveAll();
        Slide01.SetActive(true);
    }

    private void RemoveAll()
    {
        Slide01.SetActive(false);
        Slide02.SetActive(false);
        Slide03.SetActive(false);
        Slide04.SetActive(false);
        Slide05.SetActive(false);
        Slide06.SetActive(false);
        Slide07.SetActive(false);
        Slide08.SetActive(false);
        btnSlide4MenuList.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (CarOneOrTwo == 1)
        {
            Slide5Car1.SetActive(true);
            Slide5Car2.SetActive(false);
            Slide6Car1.SetActive(true);
            Slide6Car2.SetActive(false);
        }
        else
        {
            Slide5Car1.SetActive(false);
            Slide5Car2.SetActive(true);
            Slide6Car1.SetActive(false);
            Slide6Car2.SetActive(true);
        }
	}

    public void Next()
    {
       
        if (CountSlide == 0)
        {
            RemoveAll();
            Slide03.SetActive(true);
            CountSlide = 1;
        }
        else
        {
            RemoveAll();
            Slide02.SetActive(true);
            CountSlide = 0;
        }
    }

    public void Prev()
    {
        if (CountSlide == 0)
        {
            RemoveAll();
            Slide03.SetActive(true);
            CountSlide = 1;
        }
        else
        {
            RemoveAll();
            Slide02.SetActive(true);
            CountSlide = 0;
        }
    }

    public void GameFunction(string func)
    {
        if (func == "BtnSUV")
        {
            BtnSUV();
        }
        if (func == "BtnBackSlide1")
        {
            BtnBackSlide1();
        }
        
        if (func == "BtnBackSlide2")
        {
            BtnBackSlide2();
        }
        if (func == "BtnSlide4")
        {
            BtnSlide4();
        }
        if (func == "BtnSlide5")
        {
            BtnSlide5();
        }
        if (func == "BtnSlide6")
        {
            BtnSlide6();
        }

        if (func == "BtnSlide7")
        {
            BtnSlide7();
        }

        if (func == "BtnSlide8")
        {
            BtnSlide8();
        }

        if (func == "btnSlide4Menu")
        {
            btnSlide4Menu();
        }

        if (func == "Color1")
        {
            Color1();
        }

        if (func == "Color2")
        {
            Color2();
        }

        if(func == "Scene_0_Intro")
        {
            SceneManager.LoadScene("Scene_0_Intro");
        }
    }

    private void Color1()
    {
        CarOneOrTwo = 1;
    }

    private void Color2()
    {
        CarOneOrTwo = 2;
    }

    private void BtnBackSlide1()
    {
        RemoveAll();
        Slide01.SetActive(true);
    }

    private void BtnBackSlide2()
    {
        RemoveAll();
        Slide02.SetActive(true);
    }
    
    private void btnSlide4Menu()
    {
        btnSlide4MenuList.SetActive(true);
    }
    private void BtnSlide5()
    {
        RemoveAll();
        Slide05.SetActive(true);
    }

    private void BtnSUV()
    {
        RemoveAll();
        Slide02.SetActive(true);
    }

    private void BtnSlide4()
    {
        RemoveAll();
        Slide04.SetActive(true);
    }

    private void BtnSlide6()
    {
        RemoveAll();
        Slide06.SetActive(true);
    }

    private void BtnSlide7()
    {
        RemoveAll();
        Slide07.SetActive(true);
    }

    private void BtnSlide8()
    {
        RemoveAll();
        Slide08.SetActive(true);
    }

    public void ChangeDetailer()
    {
        //SceneManager.LoadScene("Scene_0_Detailer");
        GlobalMenuDialog.SetActive(true);
        print("ShowMenu");
    }
}
