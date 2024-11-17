using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : PowerUp
{
    private int healthIncrease;

    private void Start()
    {
        healthIncrease = 20;
    }

    public override void AppltyPower(Player player)
    {
        player.PowerUp(healthIncrease);
    }
}
