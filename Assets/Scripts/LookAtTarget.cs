﻿using UnityEngine;
using System.Collections;

public class LookAtTarget : MonoBehaviour {

	public Transform Target;

	// Update is called once per frame
	void Update () {
		transform.LookAt (Target);
	}
}
