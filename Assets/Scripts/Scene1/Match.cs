using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Match : MonoBehaviour, Iclick
{
    public Animator candle;
    // public Animator candle1;
    // public Animator candle2;
    public Animator player1;
    public GameObject candleObj;
    // public GameObject candle1Obj;
    // public GameObject candle2Obj;
    public void onClick(){
        candle.SetBool("isMatchClicked", true);
        // drawerWithMatch.SetActive(false);
        DOVirtual.DelayedCall(1, Player1Getcandle);
        // DOVirtual.DelayedCall(3.9f, Player1Walking);
        // DOVirtual.DelayedCall(5.7f, Player1OpeningDoor);
        DOVirtual.DelayedCall(8, GotoNextScene);
        Destroy(gameObject);
    }
    void Player1Getcandle(){
        player1.SetBool("isPick", true);
        // candle.SetBool("isPicked", true);
    }
    /* void Player1Walking(){
        candleObj.SetActive(false);
        candle1Obj.SetActive(true);
        // Walk.SetBool("isWalk", true);
        // candle.SetBool("isWalk", true);
    }
    void Player1OpeningDoor(){
        candle1Obj.SetActive(false);
        candle2Obj.SetActive(true);
        // Walk.SetBool("isOpenDoor", true);
        // candle.SetBool("isOpenDoor", true);
    } */ 
    void GotoNextScene(){
        SceneManager.LoadScene("Scene2");
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        // SceneManager.UnloadSceneAsync("Scene1");

    }
}
