using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpCamera : MonoBehaviour, Iclick, Ihint
{
    public Animator animator;
    
    public void onClick (){
        if(transform.position.y < 6)
            animator.SetTrigger("MoveUp");

        // transform.position += new Vector3 ( 0,1,0 );
        // Camera.main.transform.position += new Vector3 ( 0,1,0 );
        // GameObject.Find("Down").transform.position += new Vector3 ( 0,1,0 );
    }
    public void Hint(){
        GetComponent<Animator>().SetTrigger("Hint");
    }
}
