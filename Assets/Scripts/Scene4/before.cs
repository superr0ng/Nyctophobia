using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class before : MonoBehaviour
{
    public GameObject cursor;
    public void AllowPlay(){
        Debug.Log("AllowPlay!");
        cursor.SetActive(true);
    }
    // public void GotoNextScene(){
    //     SceneManager.LoadScene("Scene2");
    // }
}
