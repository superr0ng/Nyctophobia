using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour, Iclick
{
    public GameObject drawer;
    public GameObject match;
    // Start is called before the first frame update
    void Start()
    {
        drawer.SetActive(false);
        match.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClick(){
        // animator.SetBool("isMatchClicked", true);
        drawer.SetActive(true);
        match.SetActive(true);
    }
}
