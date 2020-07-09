using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class builder : MonoBehaviour
{
    public GameObject shadow;
    
    void Update()
    {
        if(resourceHolder.wood >= 3)
        {
            shadow.SetActive(false);
        }
        else
        {
            shadow.SetActive(true);
        }
    }
}
