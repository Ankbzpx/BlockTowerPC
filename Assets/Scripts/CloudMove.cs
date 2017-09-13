using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour {

    public float rotateAngle = 1;
	
	void Update () {
        transform.Rotate(Vector3.up, rotateAngle*Time.deltaTime);
	}
}
