using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour, Iclick
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
        // Debug.Log("clicked");
        gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
        GetComponentInParent<LightController>().LightByObject(gameObject);
    }
}