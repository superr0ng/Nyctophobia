using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour, Iclick
{
    public GameObject drawer;
    public GameObject match;
    public GameObject player1Scared;
    public GameObject player1Walk;
    // Start is called before the first frame update
    void Start()
    {
        drawer.SetActive(false);
        match.SetActive(false);
        player1Scared.SetActive(true);
        player1Walk.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClick(){
        // animator.SetBool("isMatchClicked", true);
        drawer.SetActive(true);
        match.SetActive(true);
        // player1Scared.SetActive(false);
        // player1Walk.SetActive(true);
    }
}
