using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour, Iclick
{
    // Start is called before the first frame update
    public void onClick(){
        GotoNextScene();
    }
    
    void GotoNextScene(){
        SceneManager.LoadScene("Scene1");
        // SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
    }
}
