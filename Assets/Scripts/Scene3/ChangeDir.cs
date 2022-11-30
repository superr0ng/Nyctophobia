using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class ChangeDir : MonoBehaviour
{
    // Start is called before the first frame update
    // Vector2 startPoint, sendDir, pointA, pointB;   
    // [SerializeField]
    public Vector2 startPoint, direction;
    public bool OneOut;
    public bool TwoOut;
    public bool CanRotate;
    public int dir; // 0 = up, 1 = left, 2 = down, 3 = right

    Vector2 sendDir;
    void Start()
    {
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

    public Vector3 getterRotation(){
        return transform.eulerAngles;
    }

    void OnMouseDown (){
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

            DOVirtual.DelayedCall(0.1f, IsPass);
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

            DOVirtual.DelayedCall(0.1f, IsPass);
        }
        if (CanRotate) {
            sendDir =  RotateDir(sendDir, 45);
            transform.Rotate( 0, 0, 45.0f );
        }
    }
    void IsPass(){
        if(GameObject.Find("GoToTwo-out").GetComponent<SendLightTwo>().getterPassStatus()){
            DOVirtual.DelayedCall(3, GotoNextScene);
        }
    }
    void GotoNextScene(){
        SceneManager.LoadScene("Scene4");
        // SceneManager.UnloadSceneAsync("Scene3");
        // SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
    }
    private Vector2 RotateDir(Vector2 v, float angle){
        var x = v.x;
        var y = v.y;
        var sin = System.Math.Sin(System.Math.PI * angle / 180);
        var cos = System.Math.Cos(System.Math.PI * angle / 180);
        return new Vector2((float)(x*cos+y*sin) ,(float)(x*(-sin)+y*cos));
    }
}
