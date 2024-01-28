using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [ContextMenu("Damage")]
    public void TakeDamage()
    {
        PlayerHealth.SetHealth(PlayerHealth.GetHealth()-1);
    }
}
