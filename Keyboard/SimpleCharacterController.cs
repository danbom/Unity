using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = 0f;
        float moveZ = 0f;

        if (Input.GetKey(KeyCode.W)){
            moveZ += 1f;
        }

        if (Input.GetKey(KeyCode.S)){
            moveZ -= 1f;
        }

        if (Input.GetKey(KeyCode.A)){
            moveX -= 1f;
        }

        if (Input.GetKey(KeyCode.D)){
            moveX += 1f;
        }

        // 유니티 좌표계에서 1은 1미터
        transform.Translate(new Vector3(moveX, 0f, moveZ).normalized * Time.deltaTime * 5f ); 
        // 이렇게 작성하면 1초에 1 유니티 미터씩 + 5f는 이동속도 계수로 이용
    }
}
