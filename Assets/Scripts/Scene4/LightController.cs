using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class LightController : MonoBehaviour
{
    public GameObject[] lights;
    public GameObject monster;
    public GameObject play;
    public GameObject after;
    public GameObject cursor;
    const int MAXSIZE = 10;
    int[] duration = new int[MAXSIZE];
    int[] durCnt = new int[MAXSIZE];
    bool[] isLit = new bool[MAXSIZE];
    bool isAllLit = false;
    float[] opacityList = {1f, 0.88f, 0.8f, 0.68f, 0.6f, 0.48f, 0.4f, 0.3f};
    float[] intensityList = {1f, 0.85f, 0.75f, 0.6f, 0.5f, 0.35f, 0.25f, 0.2f};
    // Start is called before the first frame update
    void Start()
    {
        DurationInit();
    }
    void DurationInit(){
        for(int i = 0; i < lights.Length; i++){
            durCnt[i] = 0;
            duration[i] = (i + 1) * 50;
            isLit[i] = false;
        }
    }
    public void LightByObject(GameObject light){
        for(int i = 0; i < lights.Length; i++){
            if(lights[i] == light){
                // Debug.Log(i.ToString() + "is clicked");
                isLit[i] = true;
                durCnt[i] = 0;
                break;
            }
        }
        int nLit = Compare();
        MonsterOpacity(nLit);

        if(isAllLit){
            cursor.SetActive(false);
            Cursor.visible = false;
            // Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
            after.SetActive(true);
            monster.SetActive(false);
            play.SetActive(false);
            // Debug.Log("EXIT");
            // DOVirtual.DelayedCall(2, EndGame);
        }
    }
    public bool IsAllLit(){
        // Debug.Log("In IsAllLit.");
        return isAllLit;
    }
    int Compare(){
        int cnt = 0;
        for(int i = 0; i < lights.Length; i++){
            if(isLit[i]){
                // Debug.Log(i.ToString() + "is not lit.");
                cnt++;
            }
        }
        if (cnt == lights.Length)
            isAllLit = true;

        return cnt;
    }
    void MonsterOpacity(int nLit){
        // float alpha = 1f - (nLit / 2 * 0.16f);
        var monsColor = monster.GetComponent<SpriteRenderer>().color;
        var MonLight = monster.GetComponentInChildren<UnityEngine.Rendering.Universal.Light2D>();
        // Debug.Log(MonLight.intensity.ToString());
        monsColor.a = opacityList[nLit];        
        monster.GetComponent<SpriteRenderer>().color = monsColor;
        MonLight.intensity = opacityList[nLit];
    }
    void FixedUpdate(){
        if(isAllLit)
            return;
        for(int i = 0; i < lights.Length; i++){
            if(isLit[i]){
                durCnt[i]++;
            }
            if(durCnt[i] >= duration[i]){
                // Debug.Log(i.ToString() + "should be turned off.");
                lights[i].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0f);
                durCnt[i] = 0;
                isLit[i] = false;
            }
        }
        int nLit = Compare();
        MonsterOpacity(nLit);
        // Debug.Log(monster.GetComponent<SpriteRenderer>().color.a.ToString());
    }
    /* void EndGame(){
        SceneManager.LoadScene("Scene0");
        // SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
    }*/ 
}
