using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class quit : MonoBehaviour
{
    public void onClick(){
        Exit();
    }
    void Exit(){
        Application.Quit();
        // SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
    }
}
