using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public int ZoomSpeed = 1;
	public float MouseLookSpeed = 60;
	bool mouseLookEnabled = false;

	// Use this for initialization
	void Start () {
		this.transform.LookAt (Vector3.zero);
	}
	
	// Update is called once per frame
	void Update () {
		//zoom
		if (Input.GetAxis ("Mouse ScrollWheel") > 0) {
			this.transform.Translate(Vector3.forward * (this.transform.position.magnitude/2));
		} else if (Input.GetAxis ("Mouse ScrollWheel") < 0){
			this.transform.Translate(-Vector3.forward * (this.transform.position.magnitude/2));
		}

		if (mouseLookEnabled) {
			//rotation
			if (Input.GetAxis ("Mouse X") > 0) {
				this.transform.RotateAround (Vector3.zero, Vector3.up, 20 * Time.deltaTime * MouseLookSpeed);
			} else if (Input.GetAxis ("Mouse X") < 0) {
				this.transform.RotateAround (Vector3.zero, Vector3.up, -20 * Time.deltaTime * MouseLookSpeed);

			}
			if (Input.GetAxis ("Mouse Y") > 0) {
				this.transform.RotateAround (Vector3.zero, Vector3.right, -20 * Time.deltaTime * MouseLookSpeed);
			} else if (Input.GetAxis ("Mouse Y") < 0) {
				this.transform.RotateAround (Vector3.zero, Vector3.right, 20 * Time.deltaTime * MouseLookSpeed);
			}
		}
	}

	public void toggleMouseLook(){
		mouseLookEnabled = !mouseLookEnabled;
	}
}
