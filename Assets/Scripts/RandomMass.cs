using UnityEngine;
using System.Collections;

public class RandomMass : MonoBehaviour {

	public int massScaler = 1;
	// Use this for initialization
	void Start () {
		int mass = Random.Range(1,100);
		this.GetComponent<Rigidbody> ().mass = mass;
		this.transform.localScale += new Vector3(mass/massScaler,mass/massScaler,mass/massScaler);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
