using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Spawner : MonoBehaviour
{
    public GameObject Pipes;
    public float waitForSeconds = 2;

    private void Start()
    {
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(waitForSeconds);
            float rand = Random.Range(-1.57f, 4.46f);
            GameObject newPipes = Instantiate(Pipes, new Vector3(2,rand,0), Quaternion.identity);
            Destroy(newPipes, 10);
        }
    }
}
