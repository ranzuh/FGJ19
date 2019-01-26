using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnter : MonoBehaviour
{
    public GameObject puukkojamppa;

    void OnTriggerEnter2D(Collider2D other) {
        puukkojamppa.SetActive(true);
    }
}
