using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puukkojamppa : MonoBehaviour
{
    public bool playerStabbed = false;
    Animator animator;
    public float speed = 3;
    void Start() {
        animator = transform.GetChild(0).GetComponent<Animator>();
        if(gameObject.activeSelf) {
            gameObject.SetActive(false);
        }
    }
    void Update() {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.tag == "Player") {
            Destroy(other.gameObject);
            playerStabbed = true;
        }
    }

    void Stoppaa() {
        speed = 0;
        animator.Play("Idle");
    }
}
