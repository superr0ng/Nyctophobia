using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDir : MonoBehaviour
{
    // Start is called before the first frame update
    // Vector2 startPoint, sendDir, pointA, pointB;   
    // [SerializeField]
    public Vector2 startPoint, direction;
    public bool canRotate;
    Vector2 sendDir;
    void Start()
    {
        // startPoint = new Vector2(5.1f, 13.3f);
        // pointA = new Vector2(0.0f, 0.0f);
        // pointB = new Vector2(1.0f, 0.0f);
        // sendDir = (pointB - pointA).normalized;
        sendDir = (direction - startPoint).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public Vector2 getterStartPoint(){
        return startPoint;
    }

    public Vector2 getterSendDir(){
        return sendDir;
    }

    void OnMouseDown (){
        if(canRotate){
            sendDir =  RotateDir(sendDir, 60);
            transform.Rotate( 0, 0, 60.0f );
        }
    }
    
    private Vector2 RotateDir(Vector2 v, float angle){
        var x = v.x;
        var y = v.y;
        var sin = System.Math.Sin(System.Math.PI * angle / 180);
        var cos = System.Math.Cos(System.Math.PI * angle / 180);
        return new Vector2((float)(x*cos+y*sin) ,(float)(x*(-sin)+y*cos));
    }
}
