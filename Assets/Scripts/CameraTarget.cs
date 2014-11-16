using UnityEngine;
using System.Collections;

public class CameraTarget : MonoBehaviour {

	public Transform Target;
	public float distance = 17;

	// Update is called once per frame
	void Update () {
		transform.position = Target.position + Target.forward*(-distance);
		transform.rotation = Target.rotation;
	}
}
