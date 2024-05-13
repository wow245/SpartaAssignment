using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    //Vector2�� ���ڷ� �޴� �Լ��� �����. 
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    //MoveEvent�� �߻� ���� �� invoke ������ �Ѵ�.
    public void CallMoveEvent(Vector2 direciton)
    {
        OnMoveEvent?.Invoke(direciton);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

}
