using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour, Iclick
{
    public AudioSource music;
    public void onClick(){
        music.Play();
        gameObject.transform.parent.parent.gameObject.GetComponent<Sign>().toggleByPlate(gameObject);
    }
}
