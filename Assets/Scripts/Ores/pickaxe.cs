using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickaxe : MonoBehaviour
{
    private cursorPlacer cp;
    private GameObject cursor;

    private void Start()
    {
        cursor = GameObject.FindGameObjectWithTag("Cursor");
        cp = cursor.GetComponent<cursorPlacer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            cp.onPickaxe(.75f, .5f, 2f);
            Destroy(gameObject);
        }
    }
}
