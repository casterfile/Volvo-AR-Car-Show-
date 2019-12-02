using UnityEngine;
using System.Collections;

public class CarRotate : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.down * Time.deltaTime * 30);
	}
}
