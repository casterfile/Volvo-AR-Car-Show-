using UnityEngine;
using System.Collections;

public class LoadCarModel : MonoBehaviour {
	public GameObject CarModel1,CarModel2;
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt ("CarModel") == 0) {
			CarModel1.SetActive (true);
			CarModel2.SetActive (false);
		} else {
			CarModel1.SetActive (false);
			CarModel2.SetActive (true);
		}
	}
}
