using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flower : Items
{


    public Text playermessage;
    public Text Stats;
    private int Intake;
    private int Karma;

    private void Awake()
    {
        Intake = 0;
        Karma = 0;
    }
    public void WriteMessage()
    {
        playermessage.text = "medical in small quantities";
        Debug.Log("pooptime");
    }

    public void UpdateStats()
    {



        Intake += Calories;
        Karma += Karmas;
        Stats.text = "You jus clicked" + Name + ", your caloric intake is " + Intake + " and your karma is " + Karma;
        if ((Intake < -30) || (Karma < -20))
        {
            Stats.text = "You Died!";
        }


    }

    public override void UseItem()
    {
        base.UseItem();
        UpdateStats();
        WriteMessage();
    }
}
