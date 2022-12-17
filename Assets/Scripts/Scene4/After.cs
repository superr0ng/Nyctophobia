using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class After : MonoBehaviour
{
    public void EndGame(){
        SceneManager.LoadScene("Scene0");
        // SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
    }
}