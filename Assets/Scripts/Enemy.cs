using UnityEngine;
using System.Collections;

public class Enemy: MonoBehaviour {
	
	public int health;
	private bool activate;
	void Start()
    {
    
    }
	void Update(){
		if (health == 0) {
            Destroy(gameObject);
		}
	}
	
}