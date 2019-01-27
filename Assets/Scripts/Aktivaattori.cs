using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aktivaattori : MonoBehaviour
{
    public Transform panel;
    public Transform spaceImage;
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

        bool clicked = panel.transform.GetChild(1).GetComponent<ChangeStatsScripts>().clicked;
        if(clicked) {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player") {
            playerOnTrigger = true;
            spaceImage.gameObject.SetActive(true);
        }
    }
    
    void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Player") {
            playerOnTrigger = false;
            panel.gameObject.SetActive(false);
            spaceImage.gameObject.SetActive(false);
        }
            
    }
}
