using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Signs : MonoBehaviour
{
    public GameObject[] signs;
    List<List<int>> characters = new List<List<int>>();
    List<List<int>> toToggles = new List<List<int>>();
    // Start is called before the first frame update
    void Start(){
        charactersInit();
        toTogglesInit();
        SignInit();
        MessSign();
    }
    void charactersInit(){
        characters.Add(new List<int> {0, 1, 2, 3, 6, 9, 12}); // L
        characters.Add(new List<int> {0, 1, 2, 4, 7, 10, 12, 13, 14}); // I
        characters.Add(new List<int> {0, 1, 2, 3, 5, 6, 8, 9, 12, 13, 14}); // G
        characters.Add(new List<int> {0, 2, 3, 5, 6, 7, 8, 9, 11, 12, 14}); // H
        characters.Add(new List<int> {1, 4, 7, 10, 12, 13, 14}); // T
    }
    void SignInit(){
        for(int i = 0; i < signs.Length; i++){
            signs[i].GetComponent<Sign>().SignInit(characters[i]);
        }
    }
    void toTogglesInit(){
        toToggles.Add(new List<int> {0, 7}); // L
        toToggles.Add(new List<int> {3, 13}); // I
        toToggles.Add(new List<int> {1, 4, 8}); // G
        toToggles.Add(new List<int> {0, 2, 5, 14}); // H
        toToggles.Add(new List<int> {2, 6, 9, 11, 12}); // T
    }
    void MessSign(){
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
    public void CompareCharacters(){
        for(int i = 0; i < signs.Length; i++){
            if(!signs[i].GetComponent<Sign>().Compare(characters[i]))
                return;
        }
        DOVirtual.DelayedCall(3, GotoNextScene);
    }
    // Update is called once per frame
    void Update()
    {
        // if(CompareCharacters()){
        //     DOVirtual.DelayedCall(3, GotoNextScene);
        //     // SceneManager.LoadScene("Scene3");
        // }
    }
    void GotoNextScene(){
        SceneManager.LoadScene("Scene3");
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
    }
}
