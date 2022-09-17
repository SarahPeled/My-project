using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    public int score;

    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public TextMeshProUGUI scoreText;
    GameObject specialWall;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        SetScoreText();
        rb = GetComponent<Rigidbody>();

        specialWall = GameObject.Find("SpecialWall");
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 2)
            {
                specialWall.SetActive(false);
            }
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            other.gameObject.SetActive(false);
            score+=1;
            SetScoreText();
        }

    }

    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }



}
