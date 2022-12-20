using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour, Iclick
{
    public AudioSource music;
    void Start(){
        Cursor.visible = true;
    }

    public void onClick(){
        music.Play();
        GotoNextScene();
    }
    
    void GotoNextScene(){
        SceneManager.LoadScene("Scene1");
        Cursor.visible = false;
    }
}
