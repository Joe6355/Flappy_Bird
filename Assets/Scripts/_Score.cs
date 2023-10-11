using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class _Score : _Sounds
{
    private float coins = 0;

    public TMP_Text coinsText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Score"))
        {
            PlaySound(sounds[0], destroyed: true);
            coins++;
            coinsText.text = coins.ToString();
        }
    }
}
