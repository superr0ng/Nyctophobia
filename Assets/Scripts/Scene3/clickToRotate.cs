using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class clickToRotate : MonoBehaviour
{
    void Start () {

    }
    
    // Update is called once per frame
    void Update () {
    }

    void OnMouseDown (){
        transform.Rotate( 0, 0, 45.0f );
        DOVirtual.DelayedCall(0.1f, IsPass);
    }
    void IsPass(){
        if(GameObject.Find("GoToTwo-out").GetComponent<SendLightThree>().getterPassStatus()){
            DOVirtual.DelayedCall(3, GotoNextScene);
        }
    }
    void GotoNextScene(){
        SceneManager.LoadScene("Scene4");
        // SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        // SceneManager.UnloadSceneAsync("Scene3");
    }
}
