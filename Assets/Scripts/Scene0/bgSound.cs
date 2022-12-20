using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgSound : MonoBehaviour {
	public GameObject obje;  
	GameObject obj = null;  
    // Use this for initialization 
	void Start () {
		obj = GameObject.Find("bgm"); 
    	if (obj == null) {  
        	obj = (GameObject)Instantiate(obje); 
        } 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
