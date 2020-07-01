using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorPlacer : MonoBehaviour
{
    private float timer;
    public GameObject pointer;
    private Vector2 cursorPos;
    public GameObject hp;
    private Collectables coll;
    public Animator anim;
    private int hpbar = 0;
    public ParticleSystem dust;
    private SpriteRenderer opacity;
    public LayerMask rock;
    private GameObject player;

    //Weapon
    private float wDamage = .5f;
    private float wTimer = .5f;
    private float distance = 1.5f;
    public bool pickaxe = false;

    private float pDamage = .5f;
    private float pTimer = .75f;
    private float pDistance = 2f;

    public void Start()
    {
        opacity = GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        opacity.color = new Color(0f, 0f, 0f, 0f);
        timer += Time.deltaTime;

        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, rock);

        if (hit)
        {
            hp.SetActive(true);
            if (hit.collider.tag == "Woods")
            {
                opacity.color = new Color(1f, 1f, 1f, 1f);              

                cursorPos = hit.collider.gameObject.transform.position;
                pointer.transform.position = new Vector2(cursorPos.x, cursorPos.y);
                coll = hit.collider.GetComponent<Collectables>();

                if (Input.GetButton("Fire1") && timer >= wTimer && (Vector3.Distance(hit.transform.position, player.transform.position) < distance))
                {
                    timer = 0;
                    coll.hitTaken(wDamage);
                    hpbar += 1;
                    dust.Play();
                }
            }
            if (hit.collider.tag == "Rocks")
            {
                opacity.color = new Color(1f, 1f, 1f, 1f);
                hp.SetActive(true);

                cursorPos = hit.collider.gameObject.transform.position;
                pointer.transform.position = new Vector2(cursorPos.x, cursorPos.y);
                coll = hit.collider.GetComponent<Collectables>();

                if (Input.GetButton("Fire1") && timer >= pTimer && (Vector3.Distance(hit.transform.position, player.transform.position) < pDistance) && pickaxe == true)
                {
                    timer = 0;
                    coll.hitTaken(pDamage);
                    hpbar += 1;
                    dust.Play();
                }
            }
            else
            {
                hp.SetActive(false);
            }

            if (hpbar == 3)
            {
                hpbar = 0;
            }

            anim.SetInteger("HP", hpbar);
        }
        else
        {
            hp.SetActive(false);
        }

    }

    public void onAxe(float status, float damage, float wDistance)
    {
        wDamage = damage;
        wTimer = status;
        distance = wDistance;
    }
    public void onPickaxe(float status, float damage, float wDistance)
    {
        pickaxe = true;
        pDamage = damage;
        pTimer = status;
        pDistance = wDistance;
    }
}
