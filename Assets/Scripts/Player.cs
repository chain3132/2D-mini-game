using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 10;
    public int Health => health;

    private float strength = 10f;
    public float Strength => strength;

    private float speed = 5.0f;
    public float Speed => speed;

    private float originalSpeed;
    private float speedBoostDuration = 0.0f;
    private float speedBoostTimer = 0.0f;
    private bool isSpeedBoostActive = false;
    
    [SerializeField]  TextMeshProUGUI healthTxt, strengthTxt, speedTxt;

    private void Start()
    {
        originalSpeed = speed;
        UpdateHealthText();
    }

    private void Update()
    {
        
        
        UpdateSpeedText();
        UpdateStrengthText();
        UpdateSpeedBoostTimer();
    }

    private void UpdateSpeedBoostTimer()
    {
        if (isSpeedBoostActive)
        {
            speedBoostTimer += Time.deltaTime;
            if (speedBoostTimer >= speedBoostDuration)
            {
                speed = originalSpeed;
                isSpeedBoostActive = false;
                Debug.Log($"Speed boost end");
            }
        }
    }

    public void PowerUp(int healthIncrease)
    {
        health += healthIncrease;
        UpdateHealthText();
        
        Debug.Log($"Health increased by {healthIncrease}. New health: {health}");
    }

    public void PowerUp(float strengthMultiplier)
    {
        strength *= strengthMultiplier;
        UpdateStrengthText();
        Debug.Log($"Strength increased by {strengthMultiplier}. New strength: {strength}");
    }
    public void PowerUp(float speedMultiplier,float duration)
    {
        if (!isSpeedBoostActive)
        {
            speed *= speedMultiplier;
            isSpeedBoostActive = true;
            speedBoostDuration = duration;
            speedBoostTimer = 0.0f;
            Debug.Log($"Speed increased by {speedMultiplier * 100}.% for {duration} seconds");
        }
        
    }
    void UpdateHealthText()
    {
        healthTxt.text = $"Health: {Health}";
    }
 
    void UpdateStrengthText()
    {
        strengthTxt.text = $"Strength: {Strength}";
    }
 
    void UpdateSpeedText()
    {
        speedTxt.text = $"Speed: {Speed}";
    }
}
