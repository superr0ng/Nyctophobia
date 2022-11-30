using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour, Iclick
{
    public GameObject drawer;
    public GameObject match;
    public GameObject brightBackground;
    public GameObject darkBackground;
    public GameObject curtain;
    public GameObject lights;
    bool canPlay = false;
    // Start is called before the first frame update
    void Start()
    {
        drawer.SetActive(false);
        match.SetActive(false);
        
        brightBackground.SetActive(true);
        darkBackground.SetActive(false);
        Invoke("ChangeBackground", 3);
    }
    public void AllowPlay(){
        canPlay = true;
    }
    public void onClick(){
        if(!canPlay)
            return;
        drawer.SetActive(true);
        match.SetActive(true);
    }
    void ChangeBackground()
    {
        brightBackground.SetActive(false);
        darkBackground.SetActive(true);
        lights.SetActive(false);
        curtain.SetActive(false);
    }
}
