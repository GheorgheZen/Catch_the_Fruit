using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOBJ : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        DestroyObject(collision.gameObject);
    }
}
