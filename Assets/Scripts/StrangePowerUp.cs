using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrangePowerUp : PowerUp
{
    private float strengthMultiplier = 2f;
    // Start is called before the first frame update
    

    public override void AppltyPower(Player player)
    {
        player.PowerUp(strengthMultiplier);
    }
}
