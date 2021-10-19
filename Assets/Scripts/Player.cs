using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    private Animation thisAnimation;

    public GameObject Wall;
    private Rigidbody rb;
    private const float jumpforce=5f;

    public Text scoretext;
    public float score;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
        score = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thisAnimation.Play();

            Jump();
        }
        if (transform.position.y <= -3.7 || transform.position.y >= 3.7)
        {
            SceneManager.LoadScene("GameOver");
        }

        scoretext.text = "SCORE: " + score;
    }
    private void Jump()
    {
        rb.velocity = Vector2.up * jumpforce;

    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Wall")
        {
            SceneManager.LoadScene("GameOver");
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="ScoreBox")
        {
            score++;
            scoretext.text = "SCORE: " + score;
        }
    }
}
