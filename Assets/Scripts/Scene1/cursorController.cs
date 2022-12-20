using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class cursorController : MonoBehaviour
{
    public Texture2D cursorCanClick;
    public AudioSource music;

    // Start is called before the first frame update
    void Start() {
        Cursor.visible = true;
        Vector2 hotSpot = new Vector2(cursorCanClick.width * 0.26f, cursorCanClick.height * 0.26f);
        Cursor.SetCursor(cursorCanClick, hotSpot, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetMouseButtonDown(0) )
        {
            Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray);
            if(hit.collider != null){
                Iclick clickObj = hit.collider.GetComponent<Iclick>();
                if(clickObj != null)
                    clickObj.onClick();
            }
            else{
                Ihint[] toHints = FindObjectsOfType<MonoBehaviour>().OfType<Ihint>().ToArray();
                foreach(Ihint toHint in toHints)
                    toHint.Hint();
                music.Play();
            }
        }
    }
}
