using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRanderer;

    private TopDownController controller;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        // 마우스의 위치가 들어오는 OnLookEvent에 등록하는 것
        // 마우스의 위치를 받아서 팔을 돌리는 데 활용할 것임.
        controller.OnLookEvent += OnAim;
    }//OnLookEvent에 OnAim함수 등록

    private void OnAim(Vector2 direction)
    {//OnLookEvent에서 좌표값을 받아온다.
        Rotate(direction);
    }

    private void Rotate(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        characterRanderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
