using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Before3 : MonoBehaviour
{
    public GameObject play;
    public GameObject before;
    public GameObject camera;
    public GameObject upButton;
    public GameObject downButton;
    public Animator animator;


    public void AllowPlay(){
        // animator.SetTrigger("MoveZoomup");
        upButton.SetActive(true);
        downButton.SetActive(true);
        play.SetActive(true);
        Cursor.visible = true;
        camera.GetComponent<LineRenderer>().enabled = !camera.GetComponent<LineRenderer>().enabled;
        before.SetActive(false);
    }
    public void CameraUp(){
        animator.SetTrigger("MoveUpup");
    }
    public void CameraZoom(){
        animator.SetTrigger("MoveZoom");
    }
    public void CameraZoomup(){
        animator.SetTrigger("MoveZoomup");
    }
}
