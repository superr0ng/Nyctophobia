using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OuterFinished : MonoBehaviour
{
    public void GotoNextScene(){
        SceneManager.LoadScene("Scene3");
        // SceneManager.UnloadSceneAsync("Scene2");
        // SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
    }
}
