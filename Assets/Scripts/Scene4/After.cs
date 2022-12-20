using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class After : MonoBehaviour
{
    public GameObject monster;
    public void EndGame(){
        SceneManager.LoadScene("Scene0");
        // SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
    }
    public void MonsterDisappears(){
        monster.SetActive(false);
    }
}