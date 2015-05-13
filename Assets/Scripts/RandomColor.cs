using UnityEngine;
using System.Collections;

public class RandomColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var go = this;
		Color newColor = new Color( Random.value, Random.value, Random.value, 1.0f );
		// apply it on current object's material
		go.GetComponent<Renderer> ().material.color = newColor;
	}
}