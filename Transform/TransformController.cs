using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float timer = 0f;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        // 누적시킨 프레임 시간 값을 코사인 그래프로 변환시켜서 포지션의 y좌표에 넣어주는 코드
        // 시간의 흐름에 따라 옵젝의 y좌표가 1에서 -1사이 왕복
        // MovePosition(new Vector3(0f, Mathf.Cos(timer), 0f));
        // MoveTranslate(new Vector3(0f, Mathf.Cos(timer), 0f));

        // y축을 기준으로 코사인 그래프를 따라서 0~360도 사이의 각도로 회전하도록
        // RotateGameObject(new Vector3(0f, (Mathf.Cos(timer) * 0.5f + 0.5f) * 360f, 0f));

        // 매개변수로 바라보고자 하는 방향
        Scaling(new Vector3(Mathf.Cos(timer) + 2f, Mathf.Cos(timer) + 2f, Mathf.Cos(timer) + 2f)); 
    }

    [SerializeField]
    private Transform lookingObj;

    public void Scaling(Vector3 newScale){
        transform.localScale = newScale;
    }

    public void LookGameObject(Transform lookObj){
        transform.LookAt(lookObj);
    }

    public void LookPosition(Vector3 pos){
        transform.LookAt(pos);
    }

    public void RotateControlForward(Vector3 dir){
        transform.forward = dir;
    }
 
    public void RotateGameObject(Vector3 rotation){
        // transform.rotation = Quaternion.Euler(rotation);
        transform.Rotate(rotation); // 개빠름
    }

    // position 함수가 매개변수로 받는 것은 위치
    public void MovePosition(Vector3 newPos){
        transform.position = newPos;
    }

    // translate 함수가 매개변수로 받는 것은 위치가 아니라,
    // 이동할 방향과 속력의 개념으로써 벡터
    public void MoveTranslate(Vector3 moveVector){
        transform.Translate(moveVector);
    }
}
