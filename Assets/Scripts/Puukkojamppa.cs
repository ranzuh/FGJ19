using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puukkojamppa : MonoBehaviour
{
    public float speed = 3;
    void Start() {
        if(gameObject.activeSelf) {
            gameObject.SetActive(false);
        }
    }
    void Update() {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player") {
            Destroy(other.gameObject);
        }
    }
}
