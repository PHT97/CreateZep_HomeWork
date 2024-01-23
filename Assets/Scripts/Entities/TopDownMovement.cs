using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        //내가 달려있는 같은 오브젝트에서 찾아오겠다 = GetComponent
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        //컨트롤러에 구독했기때문에 키보드를 누르면 Playerinputcontroller에서 상위부모에게 값을 전달함
        //구독하고있는 TopDownMovement가 실행됨
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        //이동을 처리하는 공간
        ApplyMovment(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovment(Vector2 direction)
    {
        direction = direction * 5;//이동속도를 곱함
        //velocity <- 가속도를 저장해준다.
        _rigidbody.velocity = direction;
    }
}