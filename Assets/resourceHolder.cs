using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resourceHolder : MonoBehaviour
{
    public static int stone;
    public static int wood;
    public Canvas menu;
    public Canvas UI;

    private void Start()
    {
        menu.enabled = false;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.E))
        {
            menu.enabled = true;
            UI.enabled = false;
        }
        else
        {
            menu.enabled = false;
            UI.enabled = true;
        }
    }
}
