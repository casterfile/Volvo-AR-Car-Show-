using UnityEngine;
using System.Collections;

public class CarReset : MonoBehaviour {
	private GameObject Player;
	public void Reset(){
		Player = GameObject.FindGameObjectWithTag ("Player");
		Player.transform.position = new Vector3(0, 0.08f, 0);
	}
}
