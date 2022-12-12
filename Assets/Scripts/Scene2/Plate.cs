using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour, Iclick
{
    // // Start is called before the first frame update
    
    // void Start()
    // {

    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
    public void onClick(){
        // Debug.Log("I'm clicked");
        gameObject.transform.parent.parent.gameObject.GetComponent<Sign>().toggleByPlate(gameObject);
    }
    public void Hint(){
        
    }
}
