using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour
{
	public float speed;
	public GameObject explosion;




	//What we really need
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);

		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}
	void OnCollisionEnter (Collision other)
	{
		Instantiate(explosion, transform.position, transform.rotation);
		Destroy(gameObject);
	
		Debug.Log("Touched! " + other.gameObject.name);

	}
}
