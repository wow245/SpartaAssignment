using System;
using System.Security.Claims;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    //실제로 이동이 일어날 컴포넌트

    private TopDownController controller;
    private Rigidbody2D movementRigidbody;
    private Vector2 movementDirection = Vector2.zero;
    private int speed = 5;
    

    private void Awake()
    {
        //컨트롤러를 가져오는 작업 즉, 캐싱 작업이 필요하다.
        controller = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
        

    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
        //Move라는 함수는 onMoveEvent에 등록이 되어있다.
        //입력이 있을 함수가 실행이 된다.
    }
   
    //
    private void FixedUpdate()
    {//함수를 등록해 놓고 그거에 대해서 실제론 FixedUpdate에서 적용을 하는 것이다.
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * speed;
        //정규화가 들어와서 곱해줬기때문에 speed를 곱해줄것이다.
        movementRigidbody.velocity = direction;
    }

    public void hello()
    {

    }

    public void hello1()
    {

    }
}
