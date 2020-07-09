using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oresGet : MonoBehaviour
{
    
    public int oreForce = 15;
    public int magnetSpeed = 3;
    private Rigidbody2D rb;
    private float timer;
    public float distance;
    private GameObject player;
    public bool stone;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        rb.AddForce(transform.up * oreForce);
        rb.AddForce(transform.forward * oreForce);
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer >= .40)
        {
            rb.velocity = Vector2.zero;
        }

        if (timer >= 1f)
        {
            if ((Vector3.Distance(transform.position, player.transform.position) < distance))
            {
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, Time.deltaTime * magnetSpeed);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(stone != true)
            {
                resourceHolder.wood += 1;
                if (!slotManager.newItem.Contains("wood"))
                {
                    slotManager.newItem.Add("wood");                   
                }
            }
            else
            {
                resourceHolder.stone += 1;
                if (!slotManager.newItem.Contains("stone"))
                {
                    slotManager.newItem.Add("stone");
                }
            }
            Destroy(gameObject);
        }
    }
}
