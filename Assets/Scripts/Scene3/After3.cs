using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class After3 : MonoBehaviour
{
    public void GotoNextScene(){
        SceneManager.LoadScene("Scene4");
    }
}
