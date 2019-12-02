using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Humberger : MonoBehaviour {
    public GameObject GlobalMenuDialog;
	// Use this for initialization
	public void ChangeDetailer () {
        //SceneManager.LoadScene("Scene_0_Detailer");
        GlobalMenuDialog.SetActive(true);
    }
}
