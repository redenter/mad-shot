using UnityEngine;
using System.Collections;

public class Player : Photon.MonoBehaviour {
	//	public Transform Target;
	public Rigidbody rb;
	Color activeColor = Color.white;
	Renderer renderer;

	// Use this for initialization
	void Start () {
	}


	// Update is called once per frame
	void FixedUpdate () {
		if (photonView.isMine) {
			var rot = Cardboard.SDK.HeadPose.Orientation;
			Vector3 resRot = new Vector3 (0, rot.eulerAngles.y, 0);
			rb.MoveRotation (Quaternion.Euler (resRot));
			print (transform.right);
			transform.Translate (5*transform.right
			* Time.deltaTime);
			}
		
	}
	void Update(){


	}
	
	void InputMovement()
	{
		if (Input.GetKey (KeyCode.A))
			transform.Translate (Vector3.forward * Time.deltaTime);


		if (Input.GetKey (KeyCode.D))
			transform.Translate(- Vector3.forward* Time.deltaTime);

		if (Input.GetKey (KeyCode.W))
			transform.Translate( Vector3.right * Time.deltaTime);

		if (Input.GetKey(KeyCode.S))
			transform.Translate( - Vector3.right * Time.deltaTime);

	}
}
