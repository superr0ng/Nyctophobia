using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroyMusic : MonoBehaviour {
	public static dontDestroyMusic instance;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this.gameObject); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}