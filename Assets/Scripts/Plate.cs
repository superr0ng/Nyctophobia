using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour, Iclick
{
    // Start is called before the first frame update
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void onClick(){
        GetComponentInParent<Sign>().toggleByPlate(gameObject);
    }
}
