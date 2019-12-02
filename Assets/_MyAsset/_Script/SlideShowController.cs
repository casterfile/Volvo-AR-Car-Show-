using UnityEngine;
using System.Collections;

public class SlideShowController : MonoBehaviour {

	public GameObject Car1,Car2,UIPause,UIPlay;
	private int count;
	private bool Play;


	void Start () {
		Play = true;
		count = 0;
		PlayerPrefs.SetInt("CarModel", count);
		if (count == 0) {
			Car1.SetActive (false);
			Car2.SetActive (true);
			count = 1;
		} else {
			Car1.SetActive (true);
			Car2.SetActive (false);
			count = 0;
		}

//		if (Play) {
//			UIPause.SetActive (true);
//			UIPlay.SetActive (false);
//		} else {
//			UIPause.SetActive (false);
//			UIPlay.SetActive (true);
//		}
	}

	public void NextCar(){
		if (count == 0) {
			Car1.SetActive (false);
			Car2.SetActive (true);
			count = 1;
		} else {
			Car1.SetActive (true);
			Car2.SetActive (false);
			count = 0;
		}
	}

	public void PrevCar(){
		if (count == 1) {
			Car1.SetActive (true);
			Car2.SetActive (false);
			count = 0;
		} else {
			Car1.SetActive (false);
			Car2.SetActive (true);
			count = 1;
		}
	}

//	public void PauseRotate(){
//		Play = false;
//		UIPause.SetActive (false);
//		UIPlay.SetActive (true);
//	}
//
//	public void PlayRotate(){
//		Play = true;
//		UIPause.SetActive (true);
//		UIPlay.SetActive (false);
//	}

	public void TestDrive(){
		PlayerPrefs.SetInt("CarModel", count);
		Application.LoadLevel("Scene2");
	}

	void Update () {
		if (Play) {
			Car1.transform.Rotate(Vector3.down * Time.deltaTime * 30);
			Car2.transform.Rotate(Vector3.down * Time.deltaTime * 30);
		}
	}
}
