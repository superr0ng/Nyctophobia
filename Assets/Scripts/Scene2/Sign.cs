using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour, Ihint
{    
    bool[] isLit = new bool[15];
    bool isAllLit = false;
    
    public void toggleByPlate(GameObject plate){
        int r = 0;
        int c = 0;
        for(int i = 0; i < 15; i++){
            if(gameObject.transform.GetChild(0).GetChild(i).gameObject == plate){
                r = i % 5;
                c = i / 5;
                break;
            }
        }
        toggle(r, c);
    }
    public void toggle(int r, int c){
        if(isAllLit)
            return;
        int[] r_dir = {0, 0, 1, 0, -1}; //c, r, u, l, d
        int[] c_dir = {0, 1, 0, -1, 0}; //c, r, u, l, d
        for(int i = 0; i < 5; i++){
            int rr =  r + r_dir[i];
            int cc = c + c_dir[i];
            if(rr >= 0 && rr < 5 && cc >= 0 && cc < 3){
                isLit[rr + 5 * cc] = !isLit[rr + 5 * cc];
                var lt = gameObject.transform.GetChild(1).GetChild(rr + 5 * cc).gameObject.GetComponent<UnityEngine.Rendering.Universal.Light2D>();
                lt.intensity = (lt.intensity == 0.9f)? 0.2f : 0.9f;
            }
        }
        Compare();
        if(isAllLit){
            var lts = gameObject.transform.GetChild(1).gameObject.GetComponentsInChildren<UnityEngine.Rendering.Universal.Light2D>();
            for(int i = 0 ; i < 15; i ++)
                lts[i].intensity = 1.2f;
        }
        gameObject.GetComponentInParent<Signs>().CompareCharacters();
    }
    public void SignInit(){
        for(int i = 0; i < 15; i++){
            isLit[i] = true;
        }
    }
    public bool IsAllLit(){
        return isAllLit;
    }
    void Compare(){
        for(int i = 0; i < 15; i++){
            if(!isLit[i])
                return;
        }
        isAllLit = true;
    }
    public void Hint(){
        GetComponent<Animator>().SetTrigger("Hint");
    }
}
