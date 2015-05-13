using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClearTrails : MonoBehaviour {

	public Camera cam;
	void Start()
	{
		Black ();
	}

	public void Black(){
		cam.clearFlags = CameraClearFlags.SolidColor;
	}
	public void Trails(){
		cam.clearFlags = CameraClearFlags.Depth;
	}
}
