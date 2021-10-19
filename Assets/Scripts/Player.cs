using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    private Animation thisAnimation;

    private Rigidbody rb;
    private const float jumpforce=5f;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thisAnimation.Play();

            Jump();
        }
       
    }
    private void Jump()
    {
        rb.velocity = Vector2.up * jumpforce;

    }
}
