using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownController
{
    private Camera camera;
    private void Awake()
    {
        camera = Camera.main;// mainCamera태그붙어있는 카메라를 가져온다.
    }

    public void OnMove(InputValue value)
    {//이렇게 하면 value에 w, a, s, d로 받는 벡터값이 value에 들어오게된다.
        Vector2 moveInput = value.Get<Vector2>().normalized;
        //normalized를 통해 크기가 1인 벡터를 가지고 온다.
        CallMoveEvent(moveInput);
        //실제 움직이는 처리는 여기서 하는게 아니라 PlayerMoveMent에서 함
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        CallLookEvent(newAim);
    }
}
