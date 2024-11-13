using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRig;
    private Animator anima;
    
    //Controlar velocidade do player
    public float _playerSpeed;
    //Controlar direçao do player. Eixo X e Y
    private Vector2 _playerDirection; 
    
    // Start is called before the first frame update
    void Start()
    {
        playerRig = GetComponent<Rigidbody2D>();
        anima = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
       
    }
    void MovePlayer()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        transform.position += movement * _playerSpeed * Time.deltaTime;
        //Animacao no EIXO "X"
        if (Input.GetAxis("Horizontal") > 0f)
        {
            anima.SetBool("walkRight", true);
            //anima.SetBool("walkLeft", false);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if (Input.GetAxis("Horizontal") < 0f)
        {
            anima.SetBool("walkLeft", true);
            //anima.SetBool("walkRight", false);
            transform.eulerAngles = new Vector3(0f, +180f, 0f);
        }
        if (Input.GetAxis("Horizontal") == 0f)
        {
            anima.SetBool("walkLeft", false);
            anima.SetBool("walkRight", false);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        
        // Animacao no EIXO "Y"
        if (Input.GetAxis("Vertical") > 0f)
        {
            anima.SetBool("walkUp", true);
            //anima.SetBool("walkLeft", false);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if (Input.GetAxis("Vertical") < 0f)
        {
            anima.SetBool("walkDown", true);
            //anima.SetBool("walkRight", false);
            transform.eulerAngles = new Vector3(0f, +180f, 0f);
        }
        if (Input.GetAxis("Vertical") == 0f)
        {
            anima.SetBool("walkUp", false);
            anima.SetBool("walkDown", false);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        
    }
    
}
