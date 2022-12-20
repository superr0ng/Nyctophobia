using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour, Iclick
{
    void Start(){
        Cursor.visible = true;
    }

    public void onClick(){
        GotoNextScene();
    }
    
    void GotoNextScene(){
        SceneManager.LoadScene("Scene1");
        Cursor.visible = false;
    }
}
