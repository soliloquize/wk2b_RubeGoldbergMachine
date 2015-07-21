using UnityEngine;
using System.Collections;

public class RaiseFlag : MonoBehaviour {

	bool isRaising = false;

	void Update(){
		if (isRaising == true){
			transform.position += new Vector3( 0, 1, 0) * Time.deltaTime;
		} 
	}

	public void DoRaiseFlag(){
		isRaising = true;
	}

	void OnTriggerEnter(){
		isRaising = false;
	}
}
