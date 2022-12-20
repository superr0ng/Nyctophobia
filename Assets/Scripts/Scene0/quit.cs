using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour, Iclick
{
    public AudioSource music;
    public void onClick(){
        music.Play();
        Exit();
    }
    
    void Exit(){
        // Debug.Log("Quitting"); 
        Application.Quit();
    }
}
