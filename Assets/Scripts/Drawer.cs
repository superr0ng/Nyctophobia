using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour, Iclick
{
    public GameObject drawer;
    public GameObject match;
    public GameObject drawerController;
    public GameObject brightBackground;
    public GameObject darkBackground;
    // Start is called before the first frame update
    void Start()
    {
        drawer.SetActive(false);
        match.SetActive(false);
        
        brightBackground.SetActive(true);
        darkBackground.SetActive(false);
        Invoke("ChangeBackground", 3);
        // drawerController.SetActive(false);
        // MonoBehaviour camMono = Camera.main.GetComponent<MonoBehaviour>();
        // camMono.StartCoroutine(ChangeBackground());
        /*
        StartCoroutine(ChangeBackground());
        IEnumerator ChangeBackground()
        {
            yield return new WaitForSeconds(3);
            brightBackground.SetActive(false);
            darkBackground.SetActive(true);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClick(){
        // animator.SetBool("isMatchClicked", true);
        drawer.SetActive(true);
        match.SetActive(true);
    }
    void ChangeBackground()
    {
        brightBackground.SetActive(false);
        darkBackground.SetActive(true);
    }
}
