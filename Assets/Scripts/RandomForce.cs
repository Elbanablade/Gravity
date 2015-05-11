using UnityEngine;
using System.Collections;

public class RandomForce : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody> ().AddForce (new Vector3(Random.Range(-1000,1000),Random.Range(-1000,1000),Random.Range(-1000,1000)));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
