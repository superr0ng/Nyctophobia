using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OuterFinished : MonoBehaviour
{
    void Start(){
        gameObject.SetActive(false);
    }
    public void GotoNextScene(){
        SceneManager.LoadScene("Scene3");
    }
}
