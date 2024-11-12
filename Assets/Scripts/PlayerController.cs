using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _playerRigidibody2D;
    
    //Controlar velocidade do player
    public float _playerSpeed;
    //Controlar direçao do player. Eixo X e Y
    private Vector2 _playerDirection; 
    
    // Start is called before the first frame update
    void Start()
    {
        _playerRigidibody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _playerDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }
    void FixedUpdate()
    {
        _playerRigidibody2D.MovePosition(_playerRigidibody2D.position + _playerDirection * _playerSpeed * Time.fixedDeltaTime);
    }
    
}
