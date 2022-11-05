using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickToRotate : MonoBehaviour
{
    void Start () {

    }
    
    // Update is called once per frame
    void Update () {
    }

    void OnMouseDown (){
        transform.Rotate( 0, 0, 30.0f );
    }
}
