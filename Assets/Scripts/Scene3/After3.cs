using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class After3 : MonoBehaviour
{
    public Animator animator;
    public GameObject outofLightHouse;
    public GameObject after;
    public void CameraDown(){
        animator.SetTrigger("MoveDown");
    }
    public void ActivateOutofLightHouse(){
        outofLightHouse.SetActive(true);
        after.SetActive(false);
    }
}
