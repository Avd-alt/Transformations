using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expander : MonoBehaviour
{
    [SerializeField] private float _unitsPerSecond;

    private void Update()
    {
        transform.localScale += _unitsPerSecond * Time.deltaTime * transform.localScale;
    }
}
