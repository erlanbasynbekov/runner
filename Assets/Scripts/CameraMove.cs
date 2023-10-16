using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform _target;

    void LateUpdate()
    {
        if (_target)
        { 
            transform.position = _target.position;
        }
    }
}
