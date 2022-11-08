using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Match : MonoBehaviour, Iclick
{
    public Animator animator;
    // public Animator Scared;
    // public Animator Walk;
    public GameObject player1Scared;
    public GameObject player1Walk;
    public void onClick(){
        animator.SetBool("isMatchClicked", true);
        // drawerWithMatch.SetActive(false);
        DOVirtual.DelayedCall(3, Player1Getcandle);
        DOVirtual.DelayedCall(8, GotoNextScene);
        // DOVirtual.DelayedCall(4, Player1Walking);
        // DOVirtual.DelayedCall(6, Player1OpeningDoor);
        Destroy(gameObject);
    }
    void Player1Getcandle(){
        player1Scared.SetActive(false);
        player1Walk.SetActive(true);
        animator.SetBool("isPicked", true);
    }
    /*
    void Player1Walking(){
        Walk.SetBool("isWalk", true);
        animator.SetBool("isWalk", true);
    }
    void Player1OpeningDoor(){
        Walk.SetBool("isOpenDoor", true);
        animator.SetBool("isOpenDoor", true);
    }
    */
    void GotoNextScene(){
        SceneManager.LoadScene("Scene2");
    }
}
