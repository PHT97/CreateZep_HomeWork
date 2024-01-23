using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    //MainCamera�� ã�ƿ´�.
    private Camera _camera;

    private void Awake()
    {
        //�̾��� ����ī�޶��ΰ��� ã�ƿ������Ѵ�.
        _camera = Camera.main;
    }
    // ON�� ������ ����������� �����޴� �Լ��� ����°��̴�.
    public void OnMove(InputValue value)
    {
        //normalized <- �밢������ �̵��Ҷ� �ӵ��� �������°��� ����
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }
    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();//���콺�����ǹ޾ƿ�
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);//�������������� ����
        newAim = (worldPos - (Vector2)transform.position).normalized;//worldPos�� ���ϴ� ���ͻ���
        //�����Լ� ���콺�����͸� �ٶ󺸴� ������ �޾ƿ��Եȴ�.
        if(newAim.magnitude >= .9f)
        {
            CallLookEvent(newAim);
        }
    }
}
