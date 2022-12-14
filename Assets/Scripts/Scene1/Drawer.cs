using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour, Iclick, Ihint
{
    public GameObject drawer;
    public GameObject match;
    public GameObject brightBackground;
    public GameObject darkBackground;
    public GameObject curtain;
    public GameObject lights;
    public Animator drawerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        drawer.SetActive(false);
        match.SetActive(false);
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        
        brightBackground.SetActive(true);
        darkBackground.SetActive(false);
        Invoke("ChangeBackground", 3);
    }
    public void onClick(){
        drawer.SetActive(true);
        match.SetActive(true);
        gameObject.SetActive(false);
    }
    void ChangeBackground()
    {
        brightBackground.SetActive(false);
        darkBackground.SetActive(true);
        lights.SetActive(false);
        curtain.SetActive(false);
    }
    public void Hint(){
        drawerAnimator.SetTrigger("Hint");
    }
}
