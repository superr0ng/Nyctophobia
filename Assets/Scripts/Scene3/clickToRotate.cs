using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class clickToRotate : MonoBehaviour, Iclick, Ihint
{
    public void onClick (){
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
    }
    public void Hint(){
        GetComponent<Animator>().SetTrigger("Hint");
    }
}
