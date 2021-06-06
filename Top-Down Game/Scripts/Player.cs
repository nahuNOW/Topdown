using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;
using UnityEngine.SceneManagement;
using System;

public class Player : MonoBehaviour
{
    public float speed;
    public int health = 10;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
        
        if(health < 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    internal float GetAxis(string v)
    {
        throw new NotImplementedException();
    }

    internal bool GetButtonDown(string v)
    {
        throw new NotImplementedException();
    }

    public static implicit operator Player(Rewired.Player v)
    {
        throw new NotImplementedException();
    }
}
