using UnityEngine;
using System.Collections;

public class RotateRosetta : MonoBehaviour {

	public float rotateSpeedUp = 0;
	public float rotateSpeedRight = 5;
	public float rotateSpeedForward = 5;

	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeedUp, Space.World);
		transform.Rotate(Vector3.right * Time.deltaTime * rotateSpeedRight, Space.World);
		transform.Rotate(Vector3.forward * Time.deltaTime * rotateSpeedForward, Space.World);
	}
}
