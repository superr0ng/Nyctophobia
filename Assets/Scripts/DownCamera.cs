using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update ()
    {

    }

    void OnMouseDown (){
        // Camera.main.transform.Translate(0,Time.deltaTime,0);
        transform.position -= new Vector3 ( 0,1,0 );
        Camera.main.transform.position -= new Vector3 ( 0,1,0 );
        GameObject.Find("Up").transform.position -= new Vector3 ( 0,1,0 );
    }
}
