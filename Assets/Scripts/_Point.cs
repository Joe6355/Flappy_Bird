using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Point : MonoBehaviour
{
    public GameObject column;

    private void Start()
    {
        Instantiate(column, transform.position, Quaternion.identity);
    }
}
