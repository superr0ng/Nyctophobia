using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Match : MonoBehaviour, Iclick
{
    public Animator candle;
    public Animator player1;
    public GameObject candleLight;
    public void onClick(){
        candle.SetBool("isMatchClicked", true);
        candleLight.SetActive(true);
        // drawerWithMatch.SetActive(false);
        player1.SetBool("isMatch", true);
        // DOVirtual.DelayedCall(1, Player1Getcandle);
        // DOVirtual.DelayedCall(8, GotoNextScene);
        Destroy(gameObject);
    }
    /*
    void Player1Getcandle(){
        player1.SetBool("isPick", true);
    }
    */
    /*
    void GotoNextScene(){
        SceneManager.LoadScene("Scene2");
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        // SceneManager.UnloadSceneAsync("Scene1");
    }
    */
}
