using UnityEngine;
using System.Collections;

public class TriggerCamera : MonoBehaviour {

	public Animation camAnim;

	void OnTriggerEnter(){
		camAnim.Play();
	}
}
