using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    public GameObject drawercontroller;
    public void AllowPlay(){
        Debug.Log("AllowPlay!");
        drawercontroller.GetComponent<Drawer>().AllowPlay();
    }
}
