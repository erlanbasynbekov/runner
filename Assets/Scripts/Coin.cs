using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] float _rotationSpeed;
    public AudioSource audioSource;


    void Update()
    {
        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        FindAnyObjectByType<CoinManager>().AddOne();
        Destroy(gameObject);
        audioSource.Play();
    }
}
