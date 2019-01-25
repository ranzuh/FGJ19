using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aktivaattori : MonoBehaviour
{
    public Transform panel;
    bool playerOnTrigger = false;
    
    void Update() {
        if (playerOnTrigger && Input.GetKeyDown("space"))
        {
            if(panel.gameObject.activeInHierarchy == false) {
                Debug.Log("auki");
                panel.gameObject.SetActive(true);
            }
            else {
                Debug.Log("kiinni");
                panel.gameObject.SetActive(false);
            }
        }
        else if (Input.GetKeyDown("space")) {
            panel.gameObject.SetActive(false);
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
            playerOnTrigger = true;
    }
    
    void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Player")
            playerOnTrigger = false;
            panel.gameObject.SetActive(false);
    }
}
