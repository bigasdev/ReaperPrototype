using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorPlacer : MonoBehaviour
{

    public Camera cam;
    private Vector3 mouseScreenPos;
    public GameObject pointer;

    private void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        mouseScreenPos = cam.ScreenToWorldPoint(Input.mousePosition);
        pointer.transform.position = new Vector2(Mathf.RoundToInt(mouseScreenPos.x) , Mathf.RoundToInt(mouseScreenPos.y));
    }
}
