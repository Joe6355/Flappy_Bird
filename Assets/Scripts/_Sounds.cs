using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Sounds : MonoBehaviour
{
    public AudioClip[] sounds;

    private AudioSource audioScr => GetComponent<AudioSource>();

    public void PlaySound(AudioClip clip, float volume = 1f, bool destroyed = false)
    {
        if (destroyed)
        {
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }
        audioScr.PlayOneShot(clip, volume);
    }
}
