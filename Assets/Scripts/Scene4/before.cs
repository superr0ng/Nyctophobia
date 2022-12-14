using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class before : MonoBehaviour
{
    public GameObject cursor;
    public GameObject monster;
    public Texture2D cursorCanClick;
    public Vector2 hotSpot = Vector2.zero;

    public void MonsterAppears(){
        monster.SetActive(true);
    }
    public void AllowPlay(){
        Debug.Log("AllowPlay!");
        cursor.SetActive(true);
        Cursor.SetCursor(cursorCanClick, hotSpot, CursorMode.Auto);
    }
    // public void GotoNextScene(){
    //     SceneManager.LoadScene("Scene2");
    // }
}
