using UnityEngine;
using System.Collections;

public class CameraLerp : MonoBehaviour {

	public Transform CameraTarget;
	public Transform Rosetta;

	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp (transform.position, CameraTarget.position, 0.1f);
		transform.LookAt (Rosetta);
	}
}
