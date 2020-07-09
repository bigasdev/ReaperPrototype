using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public float lifeHits = 3;
    private int randomN;
    public Transform[] orepositions;
    private bool destroyed;
    public GameObject shards;

    public void Update()
    {
        randomN = Random.Range(1, 4);      
        
        if (lifeHits <= 0)
        {
            Destroy(gameObject);
            destroyed = true;
        }


        if (destroyed == true)
        {
            if (randomN == 2)
            {
                Instantiate(shards, orepositions[0].position, orepositions[0].rotation);
                Instantiate(shards, orepositions[1].position, orepositions[1].rotation);
            }
            if(randomN == 3)
            {
                Instantiate(shards, orepositions[0].position, orepositions[0].rotation);
                Instantiate(shards, orepositions[1].position, orepositions[1].rotation);
                Instantiate(shards, orepositions[2].position, orepositions[2].rotation);
            }
            if(randomN == 1)
            {
                Instantiate(shards, orepositions[0].position, orepositions[0].rotation);
            }
        }
    }

    public void hitTaken(float damage)
    {
        lifeHits -= damage;
    }
}
