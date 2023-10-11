using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _Scene : _Sounds
{
    public void RestartLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void InvokeRestart()
    {
        Invoke("RestartLvl", 0.32f);
    }
}
