using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	Transform player; // enemy will move toward this
	//PlayerHealth playerHealth;
	//EnemyHealth enemyHealth;
	NavMeshAgent nav;

	void Start(){
		//GetComponent<Animation>().Play("orcattack");
		GetComponent<Animation>().Play("orcwalk");
		//GetComponent<Animation>().Play("orcdamage");
		//GetComponent<Animation>().Play("orcdie");
	}

	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag ("Player").transform; // remember to tag the player in inspector! 
//		playerHealth = player.GetComponent <PlayerHealth> ();
//		enemyHealth = GetComponent <EnemyHealth> ();
		nav = GetComponent <NavMeshAgent> ();
	}
	 
	// Update is called once per frame
	void Update () {
		nav.SetDestination (player.position);
	}
}
