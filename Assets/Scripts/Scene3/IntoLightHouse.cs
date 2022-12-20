using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntoLightHouse : MonoBehaviour
{
    public GameObject before;
    public GameObject intoLightHouse;
    public void ActivateBefore(){
        before.SetActive(true);
        intoLightHouse.SetActive(false);
    }
}
