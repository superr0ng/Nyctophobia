using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player1 : MonoBehaviour
{
    public GameObject drawercontroller;
    public void AllowPlay(){
        Debug.Log("AllowPlay!");
        drawercontroller.GetComponent<Drawer>().AllowPlay();
    }
    public void GotoNextScene(){
        SceneManager.LoadScene("Scene2");
        // SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
    }
}
