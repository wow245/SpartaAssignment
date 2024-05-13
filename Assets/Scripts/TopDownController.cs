using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    //Vector2를 인자로 받는 함수를 만든다. 
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    //MoveEvent가 발생 됬을 때 invoke 역할을 한다.
    public void CallMoveEvent(Vector2 direciton)
    {
        OnMoveEvent?.Invoke(direciton);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

}
