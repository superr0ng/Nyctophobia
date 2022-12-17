using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Before3 : MonoBehaviour
{
    public GameObject play;
    public GameObject before;
    public void AllowPlay(){
        play.SetActive(true);
        before.SetActive(false);
    }
}
