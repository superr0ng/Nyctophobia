using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if( Input.GetMouseButtonDown(0) )
        {
            Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray);
            if(hit.collider != null)
            {
                Iclick clickObj = hit.collider.GetComponent<Iclick>();
                if(clickObj != null)
                    clickObj.onClick();
            }
        }
    }
}
