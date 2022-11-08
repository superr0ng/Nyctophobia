using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    public GameObject player1Scared;
    public GameObject player1Walk;
    // Start is called before the first frame update
    void Start()
    {
        player1Scared.SetActive(true);
        player1Walk.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
