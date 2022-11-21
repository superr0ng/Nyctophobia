using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class innerButton : MonoBehaviour, Iclick
{
    public GameObject inner;
    public GameObject outer;
    public void onClick(){
        outer.SetActive(true);
        inner.SetActive(false);
    }
}
