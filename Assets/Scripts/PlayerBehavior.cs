using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] PlayerMove _playerMove;
    void Start()
    {
        _playerMove.enabled = false;
    
    }


    public void Play() {
        _playerMove.enabled = true;

    }
}
