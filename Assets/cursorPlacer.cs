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
    private void Start()
    {
    }

    private void Update()
    {
        timer += Time.deltaTime;
        
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        
        if (hit.collider != null)
        {
            hp.SetActive(true);
            cursorPos = hit.collider.gameObject.transform.position;
            pointer.transform.position = new Vector2(cursorPos.x, cursorPos.y);
            coll = hit.collider.GetComponent<Collectables>();
            
            if(Input.GetButton("Fire1") && timer >= .5f)
            {
                timer = 0;
                Debug.Log("Hit");
                coll.lifeHits -= 1;
                hpbar += 1;
                dust.Play();
            }
        }
        else
        {
            hp.SetActive(false);
        }

        if(hpbar == 3)
        {
            hpbar = 0;
        }

        anim.SetInteger("HP", hpbar);

    }

    void CreateDust()
    {
        dust.Play();
    }
}
