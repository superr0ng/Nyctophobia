using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class SendLight : MonoBehaviour
{
    const int Infinity = 999;

    int maxReflections = 100;
    int currentReflections = 0;

    Vector2 startPoint, direction;
    List<Vector3> Points;
    int defaultRayDistance = 100;
    LineRenderer lr;
    bool passLevel = false;

    // Use this for initialization
    void Start()
    {
        Points = new List<Vector3>();
        lr = transform.GetComponent<LineRenderer>();
    }

    private void Update()
    {    
        string thenGoTo = GameObject.Find("Main Camera").GetComponent<Reflection>().getterGoToStatus();
        if (thenGoTo == "GoToOne" || thenGoTo == "GoToTwo"){
            startPoint = GameObject.Find(thenGoTo).GetComponent<ChangeDir>().getterStartPoint();
            direction = GameObject.Find(thenGoTo).GetComponent<ChangeDir>().getterSendDir();
            
            var hitData = Physics2D.Raycast(startPoint, direction, defaultRayDistance);

            currentReflections = 0;
            Points.Clear();
            Points.Add(startPoint);

            if (hitData)
            {
                ReflectFurther(startPoint, hitData);
            }
            else
            {
                Points.Add(startPoint + direction * Infinity);
            }

            lr.positionCount = Points.Count;
            lr.SetPositions(Points.ToArray());
        }
    }

    public void ReflectFurther(Vector2 origin, RaycastHit2D hitData)
    {
        if (currentReflections > maxReflections) return;

        Vector2 inDirection = (hitData.point - origin).normalized;
        Vector2 nextStartPoint, newDirection;
        if (hitData.collider.name == "TurnOne" || hitData.collider.name == "TurnTwo"){
            Points.Add(hitData.point);
            currentReflections++;
            nextStartPoint = GameObject.Find(hitData.collider.name).GetComponent<ChangeDir>().getterStartPoint();
            newDirection = GameObject.Find(hitData.collider.name).GetComponent<ChangeDir>().getterSendDir();
        } else if ( hitData.collider.name == "LightBuld"){
            Points.Add(hitData.point);
            passLevel = true;
            // Debug.Log("Success");
            return;
        }
        else{
            newDirection = Vector2.Reflect(inDirection, hitData.normal);
            nextStartPoint = hitData.point;
        }

        Points.Add(nextStartPoint);
        currentReflections++;

        var newHitData = Physics2D.Raycast(nextStartPoint + (newDirection * 0.0001f), newDirection * 100, defaultRayDistance);
        if (newHitData)
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
}