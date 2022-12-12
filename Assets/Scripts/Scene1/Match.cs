using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Match : MonoBehaviour, Iclick, Ihint
{
    public Animator match;
    public Animator candle;
    public Animator player1;
    public GameObject candleLight;
    public GameObject cursor;
    public void onClick(){
        candle.SetBool("isMatchClicked", true);
        candleLight.SetActive(true);
        player1.SetBool("isMatch", true);
        cursor.SetActive(false);
        gameObject.SetActive(false);
    }
    public void Hint(){
        match.SetTrigger("Hint");
    }
}
