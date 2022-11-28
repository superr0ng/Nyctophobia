using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outer : MonoBehaviour
{
    public GameObject sign;
    public void AllowPlay(){
        sign.GetComponent<outerSign>().AllowPlay();
    }
}
