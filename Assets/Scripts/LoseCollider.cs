using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

    private Level_Manager levelManager;


    void Start() {
        levelManager = GameObject.FindObjectOfType<Level_Manager>();
    }
	void OnTriggerEnter2D (Collider2D trigger) {
         levelManager.LoadLevel("Lose");
    }
	
	void OnCollisionEnter2D (Collision2D collision){
	}
}
