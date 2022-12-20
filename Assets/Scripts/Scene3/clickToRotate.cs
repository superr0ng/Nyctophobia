using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class clickToRotate : MonoBehaviour, Iclick, Ihint
{
    public GameObject play;
    public GameObject after;
    public GameObject camera;
    public GameObject brightBackground;
    public GameObject upButton;
    public GameObject downButton;
    public AudioSource hintMusic;
    public AudioSource rotateMusic;
    public AudioSource LightMusic;

    public void onClick (){
        rotateMusic.Play();
        transform.Rotate( 0, 0, 45.0f );
        DOVirtual.DelayedCall(0.1f, IsPass);
    }
    void IsPass(){
        if(GameObject.Find("GoToTwo-out").GetComponent<SendLightThree>().getterPassStatus()){
            LightMusic.Play();
            brightBackground.SetActive(true);
            upButton.SetActive(false);
            downButton.SetActive(false);
            DOVirtual.DelayedCall(1, StopPlay);
        }
    }
    void StopPlay(){
        after.SetActive(true);
        play.SetActive(false);
        camera.GetComponent<LineRenderer>().enabled = false;
    }
    public void Hint(){
        GetComponent<Animator>().SetTrigger("Hint");
        hintMusic.Play();
    }
}
