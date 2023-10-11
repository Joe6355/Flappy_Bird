using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _PlayerController : _Sounds
{
    public Rigidbody2D rb;
    public int jumpForse;

    public GameObject RestartButton;

    private void Start()
    {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)|| Input.GetKeyDown(KeyCode.Mouse0)|| Input.GetKeyDown(KeyCode.Mouse1))
        {
            Jump();
            PlaySound(sounds[2], destroyed: true);
        }
    }

    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForse);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Column"))
        {
            Destroy(gameObject);
            PlaySound(sounds[3], destroyed: true);
            PlaySound(sounds[0], destroyed: true);
            RestartButton.SetActive(true);
            //Time.timeScale = 0;
        }
    }
}
