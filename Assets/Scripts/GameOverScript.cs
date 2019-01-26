using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{

    public Transform gameOverPanel;

    private bool playerDied = false;

    [SerializeField] private Text gameOverText;
    [SerializeField] private Puukkojamppa puukkojamppa;
    [SerializeField] private PlayerStatsScript playerStats;
    [SerializeField] private PauseGameScript pauseGame;


    public void Update()
    {
        PlayerDied();
        ChangeText();

        if (playerDied == true)
        {
            pauseGame.canUsePauseMenu = false;
            gameOverPanel.gameObject.SetActive(true);
        }

    }


    public void RestartPlaytime()
    {
        pauseGame.canUsePauseMenu = true;
        gameOverPanel.gameObject.SetActive(false);
    }


    public void PlayerDied()
    {
        if (playerStats.hunger >= 100 || playerStats.thirsty >= 100 || playerStats.cold >= 100 || puukkojamppa.playerStabbed == true)
        {
            playerDied = true;
        }
        else
        {
            playerDied = false;
        }
    }

    public void ChangeText()
    {
        if (playerStats.hunger >= 100)
        {
            gameOverText.text = "You died from hunger";
        }
        else if (playerStats.thirsty >= 100)
        {
            gameOverText.text = "You died from thirsty";
        }
        else if (playerStats.cold >= 100)
        {
            gameOverText.text = "You freeze to death";
        }
        else if (puukkojamppa.playerStabbed)
        {
            gameOverText.text = "You got stabbed";
            puukkojamppa.playerStabbed = false;
        }
    }
}
