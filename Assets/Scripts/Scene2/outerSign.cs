using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outerSign : MonoBehaviour, Iclick
{
    public GameObject inner;
    public GameObject outer;
    bool canPlay = false;
    void Start()
    {
        inner.SetActive(false);
        outer.SetActive(true);
    }
    public void AllowPlay(){
        canPlay = true;
    }
    public void onClick(){
        if (!canPlay){
            return;
        }
        inner.SetActive(true);
        outer.SetActive(false);

    }
}
