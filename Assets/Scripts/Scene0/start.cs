using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour, Iclick
{

    public Texture2D cursorCanClick;
    public Vector2 hotSpot = Vector2.zero;

    // Start is called before the first frame update
    void Start() {
        Cursor.SetCursor(cursorCanClick, hotSpot, CursorMode.Auto);
    }

    public void onClick(){
        GotoNextScene();
    }
    
    void GotoNextScene(){
        SceneManager.LoadScene("Scene1");
        Cursor.visible = false;
        // SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
    }
}
