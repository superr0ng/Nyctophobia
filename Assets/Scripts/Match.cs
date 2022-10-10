using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Match : MonoBehaviour, Iclick
{
    public Animator animator;
    public void onClick(){
        animator.SetBool("isMatchClicked", true);
        // drawerWithMatch.SetActive(false);
        Destroy(gameObject);
    }
}
