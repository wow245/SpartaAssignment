    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class MoveCamera : MonoBehaviour
    {
        //플레이어의 transform 값을 담을 변수를 한개 선언
        public Transform playerPos;
        public float speed;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void LateUpdate() //LateUpdate는 Update함수가 호출된 후에 호출된다.
        {
            //이렇게 하면 카메라의 위치 매 프레임 조금씩 플레이어에 다가가게 된다.
            transform.position = Vector3.Lerp(transform.position, playerPos.position, Time.deltaTime * speed);
            transform.position = new Vector3(transform.position.x, transform.position.y, -10f);
        }
    }
