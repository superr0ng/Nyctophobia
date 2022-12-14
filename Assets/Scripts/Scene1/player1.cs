using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player1 : MonoBehaviour
{
    // public GameObject drawercontroller;
    public GameObject cursor;
    public Texture2D cursorCanClick;
    public Vector2 hotSpot = Vector2.zero;

    public void AllowPlay(){
        // drawercontroller.GetComponent<Drawer>().AllowPlay();
        cursor.SetActive(true);
        Cursor.SetCursor(cursorCanClick, hotSpot, CursorMode.Auto);
    }
    public void GotoNextScene(){
        SceneManager.LoadScene("Scene2");
    }
}
