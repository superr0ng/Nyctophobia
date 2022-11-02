using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour
{
    public GameObject[] plates;
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
    public void toggle(int r, int c){
        int[] r_dir = {0, 0, 1, 0, -1}; //c, r, u, l, d
        int[] c_dir = {0, 1, 0, -1, 0}; //c, r, u, l, d
        for(int i = 0; i < 5; i++){
            int rr =  r + r_dir[i];
            int cc = c + c_dir[i];
            if(rr >= 0 && rr < 5 && cc >= 0 && cc < 3){
                plates[3 * rr + cc].GetComponent<SpriteRenderer>().color = (plates[3 * rr + cc].GetComponent<SpriteRenderer>().color == Color.white)? Color.yellow : Color.white;
            }
        }
    }
}
