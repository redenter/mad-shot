﻿using UnityEngine;
using System.Collections;

public class GolemBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


			transform.Translate(Vector3.forward * Time.deltaTime *5);

}
}