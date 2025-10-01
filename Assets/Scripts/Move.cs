using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
    }
}
