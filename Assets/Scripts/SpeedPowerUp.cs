using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : PowerUp
{
    private float speedMultiplier = 2f;

    private float duration = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    public override void AppltyPower(Player player)
    {
        player.PowerUp(speedMultiplier,duration);
    }
}
