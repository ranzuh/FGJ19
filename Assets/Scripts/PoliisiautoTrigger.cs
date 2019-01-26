using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliisiautoTrigger : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Puukkojamppa") {
            Debug.Log("Stop");
            other.SendMessage("Stoppaa");
        }
    }
}
