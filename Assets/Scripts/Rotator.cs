using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _degreesPerSecond;

    private void Update()
    {
        transform.Rotate(Vector3.up, _degreesPerSecond * Time.deltaTime);
    }
}