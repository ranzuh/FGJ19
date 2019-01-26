using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatsScript : MonoBehaviour
{

    public float hunger = 50;
    public float thirsty = 50;
    public float fatigue = 50;
    public float cold = 50;
    public float money = 100;
    public float loss = 0.1f;

    public bool canBuy = true;

    public float hungerMultiplier = 0.5f;
    public float thirstyMultiplier = 0.5f;
    public float fatigueMultiplier = 0.7f;
    public float coldMultiplier = 1f;

    [SerializeField] private Text hungerText;
    [SerializeField] private Text thirstyText;
    [SerializeField] private Text fatigueText;
    [SerializeField] private Text coldText;
    [SerializeField] private Text moneyText;


    public void Update()
    {

        hungerText.text = "Hunger: " + hunger.ToString("F0");
        thirstyText.text = "Thirsty: " + thirsty.ToString("F0");
        fatigueText.text = "Fatigue: " + fatigue.ToString("F0");
        coldText.text = "Cold: " + cold.ToString("F0");
        moneyText.text = "Money: " + money.ToString("F0");

        if (hunger > 0)
        {
            if (hunger > 100)
            {
                hunger = 100;
            }
        hunger += loss * Time.deltaTime * hungerMultiplier;
        }

        else
        {
            hunger = 0;
        }

        if (thirsty > 0)
        {
            if (thirsty > 100)
            {
                thirsty = 100;
            }
        thirsty += loss * Time.deltaTime * thirstyMultiplier;

        }

        else
        {
            thirsty = 0;
        }

        if (fatigue > 0)
        {
            if (fatigue > 100)
            {
                fatigue = 100;
            }
            fatigue += loss * Time.deltaTime * fatigueMultiplier;

        }

        else
        {
            fatigue = 0;
        }

        if (cold > 0)
        {
            if (cold > 100)
            {
                cold = 100;
            }
            cold += loss * Time.deltaTime * coldMultiplier;

        }

        else
        {
            cold = 0;
        }

    }


    public bool CanBuy(float changeMoney)
    {
        if (money + changeMoney >= 0)
        {
            canBuy = true;
        }
        else
        {
            canBuy = false;
        }
        return canBuy;
    }

    
}
