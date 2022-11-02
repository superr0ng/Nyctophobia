using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signs : MonoBehaviour
{
    public GameObject[] signs;
    // Start is called before the first frame update
    void Start(){
        List<List<int>> characters = new List<List<int>>();
        characters.Add(new List<int> {0, 1, 2, 3, 6, 9, 12}); // L
        characters.Add(new List<int> {0, 1, 2, 4, 7, 10, 12, 13, 14}); // I
        characters.Add(new List<int> {0, 1, 2, 3, 5, 6, 8, 9, 12, 13, 14}); // G
        characters.Add(new List<int> {0, 2, 3, 5, 6, 7, 8, 9, 11, 12, 14}); // H
        characters.Add(new List<int> {1, 4, 7, 10, 12, 13, 14}); // T
        for(int i = 0; i < signs.Length; i++){
            var srs = signs[i].GetComponentsInChildren<SpriteRenderer>();
            foreach(int plate in characters[i]){
                // Debug.Log(plate);
                srs[plate].color = Color.yellow;
            }
        }
        
        List<List<int>> toToggles = new List<List<int>>();
        toToggles.Add(new List<int> {0, 7}); // L
        toToggles.Add(new List<int> {3, 13}); // I
        toToggles.Add(new List<int> {1, 4, 8}); // G
        toToggles.Add(new List<int> {0, 2, 5, 14}); // H
        toToggles.Add(new List<int> {2, 6, 9, 11, 12}); // T
        for(int i = 0; i < signs.Length; i++){
            foreach(int toToggle in toToggles[i])
            {
                // Debug.Log(toToggle.ToString() + " " + (toToggle / 3).ToString() + " " + (toToggle % 3).ToString());
                signs[i].GetComponent<Sign>().toggle(toToggle / 3, toToggle % 3);
                // signs[i].transform.GetChild(0).gameObject.toggle(toToggle / 3, toToggle % 3);
                // signs[i].transform.GetChild(plate).gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
