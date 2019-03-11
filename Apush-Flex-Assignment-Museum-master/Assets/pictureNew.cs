using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pictureNew : MonoBehaviour {
	public GameObject prefab;


	void OnTriggerEnter(Collider other) {
		Instantiate (prefab);
	}
	void OnTriggerExit(Collider other){
		Destroy(prefab);
	}
}
