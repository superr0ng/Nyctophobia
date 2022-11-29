using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Reflection : MonoBehaviour
{
    const int Infinity = 999;

    int maxReflections = 100;
    int currentReflections = 0;

    [SerializeField]
    Vector2 startPoint, direction;
    List<Vector3> Points;
    int defaultRayDistance = 100;
    LineRenderer lr;
    string thenGoTo = "";

    // Use this for initialization
    void Start()
    {
        Points = new List<Vector3>();
        lr = transform.GetComponent<LineRenderer>();
    }

    private void Update()
    {
        var hitData = Physics2D.Raycast(startPoint, (direction - startPoint).normalized, defaultRayDistance);

        currentReflections = 0;
        Points.Clear();
        Points.Add(startPoint);
        thenGoTo = "";

        if (hitData)
        {
            ReflectFurther(startPoint, hitData);
        }
        else
        {
            Points.Add(startPoint + (direction - startPoint).normalized * Infinity);
        }

        lr.positionCount = Points.Count;
        lr.SetPositions(Points.ToArray());
    }

    public void ReflectFurther(Vector2 origin, RaycastHit2D hitData)
    {
        if (currentReflections > maxReflections) return;

        Vector2 inDirection = (hitData.point - origin).normalized;
        Vector2 nextStartPoint, newDirection;
        thenGoTo = "";
        if (hitData.collider.name == "TurnOne" || hitData.collider.name == "TurnTwo"){
            Points.Add(hitData.point);
            currentReflections++;
            nextStartPoint = GameObject.Find(hitData.collider.name).GetComponent<ChangeDir>().getterStartPoint();
            newDirection = GameObject.Find(hitData.collider.name).GetComponent<ChangeDir>().getterSendDir();
        } 
        else if (hitData.collider.name == "GoToOne") {
            Points.Add(hitData.point);
            currentReflections++;
            thenGoTo = "GoToTwo";
            return;
        }
        else if (hitData.collider.name == "GoToTwo") {
            Points.Add(hitData.point);
            currentReflections++;
            thenGoTo = "GoToOne";
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

    public string getterGoToStatus(){
        return thenGoTo;
    }
}