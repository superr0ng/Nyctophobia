using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour
{
    public GameObject[] plates;
    public bool[] isLit = new bool[15];
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void toggleByPlate(GameObject plate){
        int r = 0;
        int c = 0;
        for(int i = 0; i < plates.Length; i++){
            if(plates[i] == plate){
                // Debug.Log("Plate " + i.ToString());
                r = i / 3;
                c = i % 3;
            }
        }
        toggle(r, c);
    }
    void printisLit(){
        Debug.Log("===================");
        for(int i = 0; i < plates.Length; i++){
            if(isLit[i])
                Debug.Log(i.ToString());
        }
    }
    public void toggle(int r, int c){
        int[] r_dir = {0, 0, 1, 0, -1}; //c, r, u, l, d
        int[] c_dir = {0, 1, 0, -1, 0}; //c, r, u, l, d
        for(int i = 0; i < 5; i++){
            int rr =  r + r_dir[i];
            int cc = c + c_dir[i];
            if(rr >= 0 && rr < 5 && cc >= 0 && cc < 3){
                isLit[3 * rr + cc] = !isLit[3 * rr + cc];
                var color = plates[3 * rr + cc].GetComponent<SpriteRenderer>().color;
                if(color == Color.white || color == Color.black)
                    plates[3 * rr + cc].GetComponent<SpriteRenderer>().color = (color == Color.white)? Color.black : Color.white;
                else
                    plates[3 * rr + cc].GetComponent<SpriteRenderer>().color = (color == Color.yellow)? Color.gray : Color.yellow;
            }
        }
        gameObject.GetComponentInParent<Signs>().CompareCharacters();
        // printisLit();
    }
    public void SignInit(List<int> character){
        for(int i = 0; i < plates.Length; i++){
            plates[i].GetComponent<SpriteRenderer>().color = Color.white;
            // isLit[i] = true;
        }
        foreach(int pi in character){
            // Debug.Log(plate);
            plates[pi].GetComponent<SpriteRenderer>().color = Color.yellow;
            isLit[pi] = true;
        }
    }
    public bool Compare(List<int> character){
        foreach(int pi in character){
            if(!isLit[pi])
                return false;
        }
        return true;
    }
}
