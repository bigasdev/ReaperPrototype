using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public Animator anim;
    public GameObject particle;
    public Transform foot;
    public ParticleSystem dust;
    
    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.S))))
        {
            anim.SetBool("isWalking", true);
            CreateDust();

        }
        else
        {
            anim.SetBool("isWalking", false);
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }

    void CreateDust()
    {
        dust.Play();
    }
}
