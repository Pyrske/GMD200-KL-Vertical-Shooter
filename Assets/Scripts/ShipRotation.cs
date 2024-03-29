using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 3f;
    // Update is called once per frame
    void Update()
    {
        float rotate = Input.GetAxisRaw("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -rotate);
    }
}
