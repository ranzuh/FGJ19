using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditScript : MonoBehaviour
{

    Animator animator;
    public float speed = 3;


    void Start()
    {
        animator = transform.GetComponent<Animator>();
    }


    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }


    void Stoppaa()
    {
        speed = 0;
        animator.Play("Idle");
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bed")
        {
            Debug.Log("Stop");
            Stoppaa();
        }
    }
}
