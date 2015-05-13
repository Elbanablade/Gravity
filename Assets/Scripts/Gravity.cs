using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Gravity : MonoBehaviour {

	private float G = (float)6.67384 * Mathf.Pow (10, -9);
	public int forceMultiplier = 1;
	public int massScale = 1;
	private Vector3 totalForce;
	private Rigidbody[] allObjects;
	private Rigidbody self;
	public float speed = 1;

	// Use this for initialization
	void Start () {
		allObjects = UnityEngine.Object.FindObjectsOfType<Rigidbody>() ;
		self = this.GetComponent<Rigidbody> ();
		InvokeRepeating ("RunForces", 0, (1/speed)* .02f);
	}

	
	// Update is called once per frame
	void RunForces () {
		totalForce = Vector3.zero;
		foreach (Rigidbody obj in allObjects) {
			if(!self.name.Equals(obj.name))
			{
				totalForce += getForce(self,obj);
			}
		}
		self.AddRelativeForce(totalForce);
	}

	Vector3 getForce(Rigidbody obj1, Rigidbody obj2)
	{
		Vector3 direction = obj2.transform.position - obj1.transform.position;
		Vector3 unitVector = direction / direction.magnitude;
		Vector3 force = ((G*obj2.mass*obj1.mass*massScale*massScale)/(Mathf.Pow(direction.magnitude,2)))*unitVector;
		return force * forceMultiplier;
	}


}
