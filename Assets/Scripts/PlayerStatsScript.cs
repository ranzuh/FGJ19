using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatsScript : MonoBehaviour
{

    public float hunger;
    public float thirsty;
    public float fatigue;
    public float cold;
    public float money;

    [SerializeField] private Text hungerText;
    [SerializeField] private Text thirstyText;
    [SerializeField] private Text fatigueText;
    [SerializeField] private Text coldText;
    [SerializeField] private Text moneyText;


    public void Update()
    {

        hungerText.text = hunger.ToString();
        thirstyText.text = thirsty.ToString();
        fatigueText.text = fatigue.ToString();
        coldText.text = cold.ToString();
        moneyText.text = money.ToString();

    }


    public void ChangeStats(float changeHunger, float changeThirsty, float changeFatigue, float changeCold, float changeMoney)
    {

        hunger = hunger + changeHunger;
        thirsty = thirsty + changeThirsty;
        fatigue = fatigue + changeFatigue;
        cold = cold + changeCold;
        money = money + changeMoney;

    }

}
