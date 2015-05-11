using UnityEngine;
using System.Collections;

public class RandomMass : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody> ().mass = Random.Range (1, 100);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
