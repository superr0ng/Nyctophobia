using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outer : MonoBehaviour
{
    public GameObject cursor;
    // public Texture2D cursorCanClick;
    public Vector2 hotSpot = Vector2.zero;

    public void AllowPlay(){
        cursor.SetActive(true);
        Cursor.visible = true;
        // Cursor.SetCursor(cursorCanClick, hotSpot, CursorMode.Auto);
    }
}
