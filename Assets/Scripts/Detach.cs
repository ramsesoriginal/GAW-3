using UnityEngine;
using System.Collections;

public class Detach : MonoBehaviour {

	public GameObject futureParent;
	public GameObject cameraPos;
	public GameObject comet;
	public GameObject Thruster;
	public GameObject[] Tail;
	public Transform mesh;

	public bool launched;

	public float speed;
	public float rotateSpeedForward;
	public float thrusterForce;

	// Use this for initialization
	void Start () {
		launched = false;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(comet.transform);
		if (Input.anyKeyDown && !launched) {
			transform.parent = futureParent.transform;
			launched = true;
			transform.position = transform.position + transform.forward * 6;
			transform.rotation = Quaternion.identity;
			transform.LookAt(comet.transform);
			rigidbody.isKinematic = false;
			rigidbody.velocity = Vector3.zero;
			rigidbody.velocity = transform.forward * speed;
			Camera.main.transform.parent = cameraPos.transform;
			Camera.main.transform.position = cameraPos.transform.position;
			Camera.main.transform.LookAt(comet.transform);
			Camera.main.fieldOfView = 85;
			foreach(var t in Tail)
				t.SetActive(true);
			mesh.LookAt(comet.transform);
		}
		if (launched) {
			Camera.main.transform.LookAt(comet.transform);
			transform.LookAt(comet.transform);
			mesh.Rotate(transform.forward * Time.deltaTime * rotateSpeedForward, Space.Self);
			rigidbody.velocity = Vector3.Lerp(rigidbody.velocity,transform.forward * speed, 0.2f);

			if (Input.anyKey)
			{
				Thruster.SetActive (true);
				rigidbody.AddForce(-Thruster.transform.forward * thrusterForce);
			}
			else 
			{
				Thruster.SetActive (false);
			}
		}
	}
}
