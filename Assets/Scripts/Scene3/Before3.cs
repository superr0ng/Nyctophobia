using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Before3 : MonoBehaviour
{
    public GameObject play;
    public GameObject before;
    public GameObject camera;
    public void AllowPlay(){
        play.SetActive(true);
        camera.GetComponent<LineRenderer>().enabled = !camera.GetComponent<LineRenderer>().enabled;
        before.SetActive(false);
    }
}
