using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameScript : MonoBehaviour
{

    [SerializeField] public SceneControllerScript sceneController;
    public CanvasGroup canvasGroup;
    public bool playerOntrigger = false;
    public float delayTime;
    public int sceneToLoad = 2;


    private void Update()
    {
        if (playerOntrigger)
        {
            StartCoroutine(BlackCanvas());
            Invoke("DelayedScene", delayTime);
        }
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("true");
            playerOntrigger = true;
        }
    }


    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("false");
            playerOntrigger = false;
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


    public void DelayedScene()
    {
        sceneController.LoadSceneByIndex(sceneToLoad);
    }

}
