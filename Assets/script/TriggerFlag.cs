using UnityEngine;
using System.Collections;

public class TriggerFlag : MonoBehaviour {

	public GameObject flag;
	public ParticleSystem fireWork1;
	public ParticleSystem fireWork2;

	void OnTriggerEnter(){
		flag.GetComponent<RaiseFlag>().DoRaiseFlag();
		StartCoroutine(FireWork());
	}

	IEnumerator FireWork(){

		yield return new WaitForSeconds(1.5f);
		fireWork1.Play();
		fireWork2.Play();
	}

}
