using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits_Vegetables : MonoBehaviour
{
    public int score = 0;
    public float mass = 1f;

    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.mass = mass;
    }
}
