using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject[] lights;
    const int MAXSIZE = 10;
    int[] duration = new int[MAXSIZE];
    int[] durCnt = new int[MAXSIZE];
    bool[] isLit = new bool[MAXSIZE];
    bool isAllLit = false;
    // Start is called before the first frame update
    void Start()
    {
        DurationInit();
    }
    void DurationInit(){
        for(int i = 0; i < lights.Length; i++){
            durCnt[i] = 0;
            duration[i] = (i + 1) * 100;
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
        Compare();
    }
    public bool IsAllLit(){
        Debug.Log("In IsAllLit.");
        return isAllLit;
    }
    void Compare(){
        for(int i = 0; i < lights.Length; i++){
            if(!isLit[i]){
                // Debug.Log(i.ToString() + "is not lit.");
                return;
            }
        }
        isAllLit = true;
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
        Compare();
    }
}
