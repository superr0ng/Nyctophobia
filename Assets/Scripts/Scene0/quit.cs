using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour, Iclick
{
    public void onClick(){
        Exit();
    }
    
    void Exit(){
        // Debug.Log("Quitting"); 
        Application.Quit();
    }
}
