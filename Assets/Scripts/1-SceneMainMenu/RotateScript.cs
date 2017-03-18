﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateScript : MonoBehaviour {

    public float rotationSpeed;

	void Update () {
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime, Space.Self);
	}
}
