using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlate : MonoBehaviour
{
    private Touch _touch;
    private Vector3 _pos;

    [SerializeField]
    private float _speedPlane = 0.1f;


    void Update()
    {
        if (Input.touchCount > 0)
        {
            _touch = Input.GetTouch(0);

            if (_touch.phase == TouchPhase.Moved)
            {
                 _pos = new Vector3(
                    transform.position.x + _touch.deltaPosition.x * _speedPlane,
                    transform.position.y, transform.position.z);

                if (_pos.x >= 5f)
                {
                    _pos.x = 5f;
                }
                if (_pos.x <= -5f)
                {
                    _pos.x = -5f;
                }
                transform.position = _pos;
            }
        }


    }
}
