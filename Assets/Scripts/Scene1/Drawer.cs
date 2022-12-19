using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour, Iclick, Ihint
{
    public GameObject drawer;
    public GameObject match;
    public Animator drawerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        drawer.SetActive(false);
        match.SetActive(false);
        // Cursor.visible = false;
        // Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
    public void onClick(){
        drawer.SetActive(true);
        match.SetActive(true);
        gameObject.SetActive(false);
    }
    public void Hint(){
        drawerAnimator.SetTrigger("Hint");
    }
}
