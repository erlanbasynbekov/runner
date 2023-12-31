using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Barrier : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerModifier playerModifier = other.attachedRigidbody.GetComponent<PlayerModifier>();
        if (playerModifier)
        {
            playerModifier.HitBarrier();
            Destroy(gameObject); 
        }
    }
}
