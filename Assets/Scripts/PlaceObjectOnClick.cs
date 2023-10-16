using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObjectOnClick : MonoBehaviour
{
    public GameObject prefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10;

            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Instantiate(prefab, worldPosition, Quaternion.identity);
        }
    }
}
