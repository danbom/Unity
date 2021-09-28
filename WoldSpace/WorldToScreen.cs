using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldToScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject WorldObject;

    // Update is called once per frame
    void Update()
    {
        // 이미지가 따라갈 월드 스페이스의 게임 오브젝트 좌표를 스크린 스페이스로 변환
        transform.position = Camera.main.WorldToScreenPoint(WorldObject.transform.position);
    }
}
