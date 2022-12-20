using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player1 : MonoBehaviour
{
    // public GameObject drawercontroller;
    public GameObject cursor;
    // public Texture2D cursorCanClick;
    // public Vector2 hotSpot = Vector2.zero;

    public GameObject brightBackground;
    public GameObject darkBackground;
    public GameObject curtain;
    public GameObject lights;
    
    public void AllowPlay(){
        // drawercontroller.GetComponent<Drawer>().AllowPlay();
        cursor.SetActive(true);
        Cursor.visible = true;
        // Cursor.SetCursor(cursorCanClick, hotSpot, CursorMode.Auto);
    }
    void ChangeBackground()
    {
        brightBackground.SetActive(false);
        darkBackground.SetActive(true);
        lights.SetActive(false);
        curtain.SetActive(false);
    }
    public void GotoNextScene(){
        SceneManager.LoadScene("Scene2");
    }
}
