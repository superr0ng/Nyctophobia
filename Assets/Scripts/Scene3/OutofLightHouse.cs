using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutofLightHouse : MonoBehaviour
{
    public void GotoNextScene(){
        SceneManager.LoadScene("Scene4");
    }
}
