using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Growth : MonoBehaviour
{
    [SerializeField] private float _speedGrowth = 1.0f;

    void Update()
    {
        transform.localScale += new Vector3(1.0f,1.0f,1.0f) * Time.deltaTime * _speedGrowth;
        transform.localPosition += new Vector3(0, 0.5f, 0) * Time.deltaTime * _speedGrowth;
    }
}
