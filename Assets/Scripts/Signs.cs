using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Signs : MonoBehaviour
{
    public GameObject inner;
    public GameObject outer;
    List<List<int>> toToggles = new List<List<int>>();
    // Start is called before the first frame update
    void Start(){
        toTogglesInit();
        SignInit();
        MessSign();
    }
    void SignInit(){
        var SignScripts = GetComponentsInChildren<Sign>();
        for(int i = 0; i < 5; i++){
            SignScripts[i].SignInit();
        }
    }
    void toTogglesInit(){
        toToggles.Add(new List<int> {2, 14}); // L
        toToggles.Add(new List<int> {4, 7}); // I
        toToggles.Add(new List<int> {1, 6, 12}); // G
        toToggles.Add(new List<int> {0, 3, 9, 11}); // H
        toToggles.Add(new List<int> {1, 6, 8, 10, 13}); // T
    }
    void MessSign(){
        var SignScripts = GetComponentsInChildren<Sign>();
        for(int i = 0; i < 5; i++){
            foreach(int toToggle in toToggles[i])
            {
                SignScripts[i].toggle(toToggle % 5, toToggle / 5);
            }
        }
    }
    public void CompareCharacters(){
        var SignScripts = GetComponentsInChildren<Sign>();
        for(int i = 0; i < 5; i++){
            if(!SignScripts[i].Compare())
                return;
        }
        outer.SetActive(true);
        inner.SetActive(false);
        DOVirtual.DelayedCall(3, GotoNextScene);
    }
   
    void GotoNextScene(){
        SceneManager.LoadScene("Scene3");
        // SceneManager.UnloadSceneAsync("Scene2");
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
    }
}
