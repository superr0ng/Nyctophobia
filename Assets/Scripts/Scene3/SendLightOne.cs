using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class SendLightOne : MonoBehaviour
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
    int mask = 1 << 6;

    // Use this for initialization
    void Start()
    {
        Points = new List<Vector3>();
        lr = transform.GetComponent<LineRenderer>();
    }

    private void Update()
    {
        
        var hitData = Physics2D.Raycast(startPoint, (direction - startPoint).normalized, defaultRayDistance, mask);

        currentReflections = 0;
        Points.Clear();
        Points.Add(startPoint);
        thenGoTo = "";

        if (hitData) // 碰到物品
        {
            ReflectFurther(startPoint, hitData);
        }
        else // 延伸到遠方
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
        if (hitData.collider.name == "GoToOne-in") {
            var CubeDir = GameObject.Find("GoToOne-in").GetComponent<ChangeDir>().getterRotation();
            Points.Add(hitData.point);
            currentReflections++;
            if (CubeDir.z > 310 && CubeDir.z < 330){
                thenGoTo = "GoToOne-out";
            }
            return;
        }
        else if (hitData.collider.name == "GoToTwo-in") {
            var CubeDir = GameObject.Find("GoToTwo-in").GetComponent<ChangeDir>().getterRotation();
            Points.Add(hitData.point);
            currentReflections++;
            if (CubeDir.z == 0 || CubeDir.z == 360){
                thenGoTo = "GoToTwo-out";
            }
            return;
        }
        else if (hitData.collider.name == "Up" || hitData.collider.name == "Down"){
            Points.Add(hitData.point);
            currentReflections++;
            return;
        }
        
        newDirection = Vector2.Reflect(inDirection, hitData.normal);
        nextStartPoint = hitData.point;
        Points.Add(nextStartPoint);
        currentReflections++;

        var newHitData = Physics2D.Raycast(nextStartPoint + (newDirection * 0.0001f), newDirection * 100, defaultRayDistance, mask);
        if (newHitData) // 碰到物品
        {
            ReflectFurther(nextStartPoint, newHitData);
        }
        else // 延伸到遠方
        {
            Points.Add(nextStartPoint + newDirection * defaultRayDistance);
        }
    }
    public string getterGoToStatus(){
        return thenGoTo;
    }
}