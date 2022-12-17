using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class After3 : MonoBehaviour
{
    public Animator animator;
    public void CameraDown(){
        animator.SetTrigger("MoveDown");
    }
    public void GotoNextScene(){
        SceneManager.LoadScene("Scene4");
    }
}
