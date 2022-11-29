using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class SendLightTwo : MonoBehaviour
{
    const int Infinity = 999;

    int maxReflections = 100;
    int currentReflections = 0;

    Vector2 startPoint, direction;
    List<Vector3> Points;
    int defaultRayDistance = 100;
    LineRenderer lr;
    string AndThenGoTo = "";
    bool passLevel = false;

    // Use this for initialization
    void Start()
    {
        Points = new List<Vector3>();
        lr = transform.GetComponent<LineRenderer>();
    }

    private void Update()
    {    
        AndThenGoTo = "";
        currentReflections = 0;
        Points.Clear();
        string thenGoTo = "";
        thenGoTo = GameObject.Find("Main Camera").GetComponent<SendLightOne>().getterGoToStatus();
        if (thenGoTo == "GoToOne-out"){
            startPoint = GameObject.Find(thenGoTo).GetComponent<ChangeDir>().getterStartPoint();
            direction = GameObject.Find(thenGoTo).GetComponent<ChangeDir>().getterSendDir();
            
            var hitData = Physics2D.Raycast(startPoint, direction, defaultRayDistance);
            Points.Add(startPoint);
            if (hitData) // 碰到物品
            {
                ReflectFurther(startPoint, hitData);
            }
            else
            {
                Points.Add(startPoint + direction * Infinity);
            }
        }
        
        lr.positionCount = Points.Count;
        lr.SetPositions(Points.ToArray());
    }

    public void ReflectFurther(Vector2 origin, RaycastHit2D hitData)
    {
        if (currentReflections > maxReflections) return;

        Vector2 inDirection = (hitData.point - origin).normalized;
        Vector2 nextStartPoint, newDirection;
        AndThenGoTo = "";
        if (hitData.collider.name == "GoToTwo-in") {
            var CubeDir = GameObject.Find("GoToTwo-in").GetComponent<ChangeDir>().getterRotation();
            Points.Add(hitData.point);
            AndThenGoTo = "";
            currentReflections++;
            if (CubeDir.z < 10 || CubeDir.z > 350){
                AndThenGoTo = "GoToTwo-out";
            }
            return;
        } else if ( hitData.collider.name == "LightBuld"){
            Points.Add(hitData.point);
            passLevel = true;
            // Debug.Log("Success");
            return;
        } else if (hitData.collider.name == "Up" || hitData.collider.name == "Down"){
            Points.Add(hitData.point);
            currentReflections++;
            return;
        }

        newDirection = Vector2.Reflect(inDirection, hitData.normal);
        nextStartPoint = hitData.point;
        Points.Add(nextStartPoint);
        currentReflections++;

        var newHitData = Physics2D.Raycast(nextStartPoint + (newDirection * 0.0001f), newDirection * 100, defaultRayDistance);
        if (newHitData) // 碰到物品
        {
            ReflectFurther(nextStartPoint, newHitData);
        }
        else
        {
            Points.Add(nextStartPoint + newDirection * defaultRayDistance);
        }
    }

    public bool getterPassStatus(){
        return passLevel;
    }

    public string getterAndThenGoToStatus(){
        return AndThenGoTo;
    }
}