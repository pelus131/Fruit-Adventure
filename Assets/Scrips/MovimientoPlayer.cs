using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{

    public float velocidad = 2;
    public float velocidadSalto = 3;
    Rigidbody2D pj;

    public bool saltov2 = false;
    public float caida = 0.5f;
    public float saltobajo = 1f;

    public SpriteRenderer spriteRenderer;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        pj = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d")|| Input.GetKey("right"))
        {
            pj.velocity = new Vector2(velocidad, pj.velocity.y);
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            pj.velocity = new Vector2(-velocidad, pj.velocity.y);
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);
        }
        else
        {
            pj.velocity = new Vector2(0, pj.velocity.y);
            animator.SetBool("Run", false);
        }
        if (Input.GetKey("space") && CheckGround.tierra) {
            pj.velocity = new Vector2(pj.velocity.x, velocidadSalto);

        }
        if (CheckGround.tierra==false)
        {
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }
        if (CheckGround.tierra==true)
        {
            animator.SetBool("Jump", false);
        }
        if (saltov2)
        {
            if (pj.velocity.y<0)
            {
                pj.velocity += Vector2.up * Physics2D.gravity.y * (caida) * Time.deltaTime;
            }
            if (pj.velocity.y>0 && !Input.GetKey("space"))
            {
                pj.velocity += Vector2.up * Physics2D.gravity.y * (saltobajo) * Time.deltaTime;
            }

        }

    }
}
