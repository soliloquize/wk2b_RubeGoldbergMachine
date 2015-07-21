using UnityEngine;
using System.Collections;

public class TriggerFlag : MonoBehaviour {

	public GameObject flag;

	void OnTriggerEnter(){
		flag.GetComponent<RaiseFlag>().DoRaiseFlag();
	}

}
