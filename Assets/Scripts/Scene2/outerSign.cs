using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outerSign : MonoBehaviour, Iclick, Ihint
{
    public GameObject inner;
    public GameObject outer;
    public Animator signAnimator;
    void Start()
    {
        inner.SetActive(false);
        outer.SetActive(true);
    }
    public void onClick(){
        inner.SetActive(true);
        outer.SetActive(false);
    }
    public void Hint(){
        signAnimator.SetTrigger("Hint");
    }
}
