﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class CameraFollow : MonoBehaviour {

	[SerializeField] private Transform target;    // the target we need to follow.
	[SerializeField] private float smoothing = 5f; //camera follow speed.

	Vector3 offset;

	void Awake()
	{
		Assert.IsNotNull (target);
	}

	// Use this for initialization
	void Start () {
		offset = transform.position - target.position;       // offset is diff. between target and camera.
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetCamPosition = target.position + offset;
		transform.position = Vector3.Lerp (transform.position, targetCamPosition, smoothing * Time.deltaTime);      // lerp is linear move between 2 axis.
	}
}
