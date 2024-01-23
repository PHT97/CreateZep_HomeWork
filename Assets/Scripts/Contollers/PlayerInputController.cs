using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    //MainCamera를 찾아온다.
    private Camera _camera;

    private void Awake()
    {
        //이씬의 메인카메라인것을 찾아오도록한다.
        _camera = Camera.main;
    }
    // ON을 붙히면 실행됬을경우 돌려받는 함수를 만드는것이다.
    public void OnMove(InputValue value)
    {
        //normalized <- 대각선으로 이동할때 속도가 빨라지는것을 방지
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }
    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();//마우스포지션받아옴
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);//월드포지션으로 변경
        newAim = (worldPos - (Vector2)transform.position).normalized;//worldPos로 향하는 벡터생성
        //나에게서 마우스포인터를 바라보는 방향을 받아오게된다.
        if(newAim.magnitude >= .9f)
        {
            CallLookEvent(newAim);
        }
    }
}
