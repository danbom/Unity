using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptingPractice : MonoBehaviour
{
    // Awake : 스크립트 인스턴스가 로딩될 때 한 번 호출된다
    // 모노비헤이비어 클래스가 컴포넌트로써 게임 오브젝트에 부착될 때 한 번 실행
    // 컴포넌트에 대한 초기화가 필요할 경우 사용
    // 생성자 대신 사용
    private void Awake() {
        Debug.Log("Awake");
    }

    // OnEnable : 모노비헤이비어를 상속받은 컴포넌트가 부착된 게임 오브젝트가 활성화될 때 마다 호출
    private void OnEnable() {
        Debug.Log("OnEnable");
    }

    // Start : Update 함수가 실행되기 직전에 단 한 번 호출되는 함수
    // 게임 오브젝트가 활성화인 상태에만 호출된다
    void Start()
    {
        Debug.Log("Start");
    }

    // Update : 모노비헤이비어가 활성화된 상태에서 매 프레임마다 호출
    // 대부분의 게임 동작 작성
    // 프레임마다 호출되기 때문에 프레임드랍이 발생하는 경우에 호출 횟수가 줄어
    // 게임 처리가 원활하지 않게 되는 경우 발생
    // 프레임과 상관없이 코드가 동작되길 원한다면
    // FixedUpdate 사용
    // void Update()
    // {
    //     Debug.Log("Update");
    // }

    int updateCount = 5;
    void Update(){
        updateCount--;
        if (updateCount >= 0){
            Debug.Log("Update :: " + updateCount);
        } else {
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    // LateUpdate : Update 함수에서 모든 처리를 끝내고 결과가 반영된 뒤에 처리되게 하고 싶을 때
    void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    // OnDisable : 모노비헤이비어가 비활성화되는 경우 호출
    private void OnDisable() {
        Debug.Log("OnDisable");
    }

    // OnDestroy : 모노비헤이비어가 제거될 때 호출
    private void OnDestroy() {
        Debug.Log("OnDestroy");
    }
}
