using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMove : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    
    void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime * _speed;
    }
}
