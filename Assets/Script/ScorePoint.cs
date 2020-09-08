using UnityEngine;
using System.Collections;

public class ScorePoint : MonoBehaviour {

    public Score spawnLink;

    void Awake()
    {

        spawnLink = GameObject.Find("Gerenciador").GetComponent<Score>();
    }

    void OnCollisionEnter2D(Collision2D coll) { 
		if(coll.gameObject.tag == "Player") {
			spawnLink.pontos ++ ;
			gameObject.SetActive(false);
		}
	}
}
