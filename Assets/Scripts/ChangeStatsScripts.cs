using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeStatsScripts : MonoBehaviour
{

    public PlayerStatsScript playerStats;
    public Button choiseButton;
    public float changeHunger;
    public float changeThirsty;
    public float changeFatigue;
    public float changeCold;
    public float changeMoney;

    private bool clicked = false;


    public void Update()
    {
        if (playerStats.CanBuy(changeMoney) && clicked == false)
        {
            choiseButton.interactable = true;
        }
        else
        {
            choiseButton.interactable = false;
        }

    }


    public void ActionDone()
    {
        clicked = true;
    }


    public void ChangeStats()
    {
        playerStats.hunger = playerStats.hunger + changeHunger;
        playerStats.thirsty = playerStats.thirsty + changeThirsty;
        playerStats.fatigue = playerStats.fatigue + changeFatigue;
        playerStats.cold = playerStats.cold + changeCold;
        playerStats.money = playerStats.money + changeMoney;
    }

}
