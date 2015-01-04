using UnityEngine;
using System.Collections;

public class GameOverManager : MonoBehaviour {

	Animator anim;

	public GameObject player;

	// Use this for initialization
	void Awake ()
	{
		anim = GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (!player)
		{
			anim.SetTrigger ("GameOver");
		
		}
	}
	
}
