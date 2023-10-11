using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _Column : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
