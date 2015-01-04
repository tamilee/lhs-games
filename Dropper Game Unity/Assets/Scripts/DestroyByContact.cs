using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {
	public GameObject explosion;

	void Start(){
		Debug.Log(this.name);
		Debug.Log(this.gameObject.collider.isTrigger);
	}

	void OnCollisionEnter (Collision other) {
		Debug.Log("Touched!");
		if(other.gameObject.name  == "Player")
		{
			Instantiate(explosion, other.transform.position, other.transform.rotation);
			Destroy(other.gameObject);
		}

	}
}
