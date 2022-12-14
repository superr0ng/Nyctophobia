using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player1 : MonoBehaviour
{
    // public GameObject drawercontroller;
    public GameObject cursor;
    public void AllowPlay(){
        // drawercontroller.GetComponent<Drawer>().AllowPlay();
        cursor.SetActive(true);
    }
    public void GotoNextScene(){
        SceneManager.LoadScene("Scene2");
    }
}
