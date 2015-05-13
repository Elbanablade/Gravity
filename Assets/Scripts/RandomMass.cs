using UnityEngine;
using System.Collections;

public class RandomMass : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int mass = Random.Range(1,100);
		this.GetComponent<Rigidbody> ().mass = mass;
		this.transform.localScale = new Vector3(mass,mass,mass);
	}
	
}
