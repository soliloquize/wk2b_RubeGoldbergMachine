using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {


	void Update () {
	if (Input.GetKeyDown(KeyCode.Space)){
			transform.position = new Vector3( -36.33f, 32f, 30f);

		}
	}
}
