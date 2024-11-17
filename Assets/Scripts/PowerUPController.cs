using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUPController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Player player = other.GetComponent<Player>();
        PowerUp powerUp = GetComponent<PowerUp>();

        if (powerUp != null && player != null )
        {
            powerUp.AppltyPower(player);
            Destroy(gameObject);
        }
    }
}
