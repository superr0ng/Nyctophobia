using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class ChangeDir : MonoBehaviour, Iclick, Ihint
{
    // Start is called before the first frame update
    // Vector2 startPoint, sendDir, pointA, pointB;   
    // [SerializeField]
    public Vector2 startPoint, direction;
    public bool OneOut;
    public bool TwoOut;
    public bool CanRotate;
    public int dir; // 0 = up, 1 = left, 2 = down, 3 = right
    // bool gameStart = false;
    bool gameEnd = false;

    Vector2 sendDir;
    void Start()
    {
        sendDir = (direction - startPoint).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameEnd && GameObject.Find("GoToTwo-out").GetComponent<SendLightThree>().getterPassStatus()){
            gameEnd = true;
            DOVirtual.DelayedCall(1, GotoNextScene);
        }
    }
    
    public Vector2 getterStartPoint(){
        return startPoint;
    }

    public Vector2 getterSendDir(){
        return sendDir;
    }

    public Vector3 getterRotation(){
        return transform.eulerAngles;
    }

    public void onClick(){
        if (OneOut){
            sendDir =  RotateDir(sendDir, 90);
            transform.Rotate( 0, 0, -90.0f );
            if(dir == 3) dir = 0;
            else dir += 1;

            if(dir == 0) 
                startPoint = transform.position + new Vector3(0f, 0.3f, 0);
            else if(dir == 1)
                startPoint = transform.position + new Vector3(0.3f, 0f, 0);
            else if(dir == 2)
                startPoint = transform.position - new Vector3(0f, 0.3f, 0);
            else if(dir == 3)
                startPoint = transform.position - new Vector3(0.3f, 0f, 0);
        }
        if (TwoOut){
            sendDir =  RotateDir(sendDir, 90);
            transform.Rotate( 0, 0, -90.0f );
            if(dir == 3) dir = 0;
            else dir += 1;

            if(dir == 0) 
                startPoint = transform.position + new Vector3(0.23f, 0.23f, 0);
            else if(dir == 1)
                startPoint = transform.position + new Vector3(0.23f, 0, 0) - new Vector3(0, 0.23f, 0);
            else if(dir == 2)
                startPoint = transform.position - new Vector3(0.23f, 0.23f, 0);
            else if(dir == 3)
                startPoint = transform.position - new Vector3(0.23f, 0, 0) + new Vector3(0, 0.23f, 0);
        }
        if (CanRotate) {
            sendDir =  RotateDir(sendDir, 45);
            transform.Rotate( 0, 0, 45.0f );
        }
    }
    void GotoNextScene(){
        SceneManager.LoadScene("Scene4");
    }
    private Vector2 RotateDir(Vector2 v, float angle){
        var x = v.x;
        var y = v.y;
        var sin = System.Math.Sin(System.Math.PI * angle / 180);
        var cos = System.Math.Cos(System.Math.PI * angle / 180);
        return new Vector2((float)(x*cos+y*sin) ,(float)(x*(-sin)+y*cos));
    }
    public void Hint(){
        GetComponent<Animator>().SetTrigger("Hint");
    }
}
