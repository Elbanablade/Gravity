using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {

	private float G = (float)6.67384 * Mathf.Pow (10, -9);
	public int forceMultiplier = 1;
	public int massScale = 1;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		GameObject[] allObjects = getAllGameobjectsInScene ();
		foreach (GameObject obj in allObjects) {
			if(!this.name.Equals(obj.name) && !obj.name.Equals("Camera") && !obj.name.ToLower().Equals("directional light"))
			{
				this.GetComponent<Rigidbody>().AddRelativeForce(getForce(this.GetComponent<Rigidbody>(),obj.GetComponent<Rigidbody>()));
			}
		}
	}

	GameObject[] getAllGameobjectsInScene()
	{
		return UnityEngine.Object.FindObjectsOfType<GameObject>() ;
	}

	Vector3 getForce(Rigidbody obj1, Rigidbody obj2)
	{
		Vector3 direction = obj2.transform.position - obj1.transform.position;
		Vector3 unitVector = direction / direction.magnitude;
		Vector3 force = ((G*obj2.mass*obj1.mass*massScale*massScale)/(Mathf.Pow(direction.magnitude,2)))*unitVector;
		return force * forceMultiplier;
	}


}
