using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public int lifeHits = 3;

    public void Update()
    {
        if (lifeHits <= 0)
        {
            Destroy(gameObject);
        }
    }
}
