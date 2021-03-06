﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float addIntensity = 1f;
    [SerializeField] float restoreAngle = 90f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            var flashlight = other.GetComponentInChildren<FlashlightSystem>();
            flashlight.RestoreLightAngle(restoreAngle);
            flashlight.RestoreLightIntensity(addIntensity);
            Destroy(gameObject);
        }
    }
}
