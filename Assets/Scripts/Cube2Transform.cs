using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2Transform : MonoBehaviour
{
    [SerializeField] private float _speed = 50.0f;
    [SerializeField] private float _speedGrowth = 1.0f;
    [SerializeField] private float _speedRotateon = 10.0f;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        transform.RotateAround(gameObject.transform.position, -Vector3.up, Time.deltaTime * _speedRotateon);
        transform.localScale += new Vector3(1.0f, 1.0f, 1.0f) * Time.deltaTime * _speedGrowth;
        transform.localPosition += new Vector3(0, 0.5f, 0) * Time.deltaTime * _speedGrowth;
    }
}
