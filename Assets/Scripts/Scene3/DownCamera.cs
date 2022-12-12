using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownCamera : MonoBehaviour
{
    public Animator animator;

    void OnMouseDown (){
        if(transform.position.y > 15)
            animator.SetTrigger("MoveDown");
            
        // Camera.main.transform.Translate(0,Time.deltaTime,0);
        // transform.position -= new Vector3 ( 0,1,0 );
        // Camera.main.transform.position -= new Vector3 ( 0,1,0 );
        // GameObject.Find("Up").transform.position -= new Vector3 ( 0,1,0 );
    }
}
