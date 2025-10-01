using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] private float _speed = 200.0f;

    void Update()
    {
        transform.RotateAround(gameObject.transform.position, Vector3.up, _speed * Time.deltaTime); 
    }
}
