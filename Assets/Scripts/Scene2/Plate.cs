using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour, Iclick
{
    public void onClick(){
        gameObject.transform.parent.parent.gameObject.GetComponent<Sign>().toggleByPlate(gameObject);
    }
}
