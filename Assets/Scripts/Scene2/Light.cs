using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Light : MonoBehaviour, Iclick, Ihint
{

    public AudioSource music;
    
    public void onClick(){
        // Debug.Log("clicked");

        gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
        GetComponentInParent<LightController>().LightByObject(gameObject);
    }
    public void Hint(){
        music.Play();
        GetComponent<Animator>().SetTrigger("Hint");
    }
}
