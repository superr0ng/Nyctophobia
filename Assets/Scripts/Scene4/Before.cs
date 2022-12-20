using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Before : MonoBehaviour
{
    public GameObject cursor;
    public GameObject monster;
    public GameObject before;
    public GameObject play;
    public GameObject stage;
    // public Texture2D cursorCanClick;
    // public Vector2 hotSpot = Vector2.zero;
    
    
    public void MonsterAppears(){
        monster.SetActive(true);
    }
    public void AllowPlay(){
        // Debug.Log("AllowPlay!");
        cursor.SetActive(true);
        stage.SetActive(true);
        Cursor.visible = true;
        // Cursor.SetCursor(cursorCanClick, hotSpot, CursorMode.Auto);
        play.SetActive(true);
        before.SetActive(false);
    }
}
