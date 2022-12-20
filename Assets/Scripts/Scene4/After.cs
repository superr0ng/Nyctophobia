using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class After : MonoBehaviour
{
    public GameObject monster;
    // void Start(){
    //     gameObject.SetActive(false);
    // }
    public void EndGame(){
        SceneManager.LoadScene("Scene0");
    }
    public void MonsterDisappears(){
        monster.SetActive(false);
    }
}