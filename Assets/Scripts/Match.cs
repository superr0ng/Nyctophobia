using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Match : MonoBehaviour, Iclick
{
    public Animator animator;
    public void onClick(){
        animator.SetBool("isMatchClicked", true);
        // drawerWithMatch.SetActive(false);
        DOVirtual.DelayedCall(3, GotoNextScene);
        Destroy(gameObject);
    }
    void GotoNextScene(){
        SceneManager.LoadScene("Scene2");
    }
}
