    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class MoveCamera : MonoBehaviour
    {
        //�÷��̾��� transform ���� ���� ������ �Ѱ� ����
        public Transform playerPos;
        public float speed;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void LateUpdate() //LateUpdate�� Update�Լ��� ȣ��� �Ŀ� ȣ��ȴ�.
        {
            //�̷��� �ϸ� ī�޶��� ��ġ �� ������ ���ݾ� �÷��̾ �ٰ����� �ȴ�.
            transform.position = Vector3.Lerp(transform.position, playerPos.position, Time.deltaTime * speed);
            transform.position = new Vector3(transform.position.x, transform.position.y, -10f);
        }
    }
