using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Light : MonoBehaviour, Iclick
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClick(){
        // Debug.Log("clicked");

        gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
        GetComponentInParent<LightController>().LightByObject(gameObject);
        if(gameObject.GetComponentInParent<LightController>().IsAllLit()){
            Debug.Log("EXIT");
            DOVirtual.DelayedCall(2, EndGame);
        }
    }
    void EndGame(){
        SceneManager.LoadScene("Scene0");
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
    }
}
