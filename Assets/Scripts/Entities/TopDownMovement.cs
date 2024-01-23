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
        //���� �޷��ִ� ���� ������Ʈ���� ã�ƿ��ڴ� = GetComponent
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        //��Ʈ�ѷ��� �����߱⶧���� Ű���带 ������ Playerinputcontroller���� �����θ𿡰� ���� ������
        //�����ϰ��ִ� TopDownMovement�� �����
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        //�̵��� ó���ϴ� ����
        ApplyMovment(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovment(Vector2 direction)
    {
        direction = direction * 5;//�̵��ӵ��� ����
        //velocity <- ���ӵ��� �������ش�.
        _rigidbody.velocity = direction;
    }
}