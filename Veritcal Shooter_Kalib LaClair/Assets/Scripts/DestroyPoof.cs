using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class ShipHealth
{
    public static event Action<int> healthChanged;
    private static int _health;
    public static void SetHealth(int health)
    {
        if (health == _health)
        {
            return;
        }
        _health = health;
        healthChanged?.Invoke(health);
    }

}
