using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public int steps = 5;
    public bool died = false;
    public AudioSource gameOverSound;
    public GameObject gameOverScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOverSound = GetComponent<AudioSource>();
        gameOverScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!died)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.position += new Vector3(0, 0, steps);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.position += new Vector3(0, 0, -steps);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.position += new Vector3(steps, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.position += new Vector3(-steps, 0, 0);
            }
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Ovr");
            gameOverSound.Play();
            gameOverScreen.SetActive(true);
            died = true;
        }
    }
}
