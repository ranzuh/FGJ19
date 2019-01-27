using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsBlackScreenScript : MonoBehaviour
{

    public CanvasGroup canvasGroup;
    public bool playerOnTrigger = false;
    public Transform creditPanel;



    private void Update()
    {
        if (playerOnTrigger)
        {
            StartCoroutine(BlackCanvas());
                if (canvasGroup.alpha == 1)
                {
                    creditPanel.gameObject.SetActive(true);
                }
        }
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("true");
            playerOnTrigger = true;
        }
    }


    public IEnumerator BlackCanvas()
    {
        while (canvasGroup.alpha < 1)
        {
            canvasGroup.alpha += Time.deltaTime / 10;
            yield return null;
        }
        canvasGroup.interactable = false;
        yield return null;
    }


    public void ButtonPressed()
    {
        playerOnTrigger = false;
    }

}
