using UnityEngine;
using System.Collections;

public class IntoTheTube : MonoBehaviour {

	public GameObject outTube;

	void OnTriggerEnter(){
		Destroy(outTube);
	}


}
