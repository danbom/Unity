using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorParameterPractice : MonoBehaviour
{
    private Animator animator;

    // 게임이 시작된 직후에 게임 오브젝트에 부착된 Animator 컴포넌트를 가져오기 위해
    // GetComponent 함수 사용
    void Awake() {
        animator = GetComponent<Animator>(); // 지금 이 컴포넌트가 부착되어있는 게임 오브젝트에 부착된 다른 컴포넌트 가져올 수 있다

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)){
            animator.SetFloat("New Float", 3.1f);
        }

        if (Input.GetKeyUp(KeyCode.F)){
            animator.SetFloat("New Float", 2.9f);
        }

        if (Input.GetKeyDown(KeyCode.I)){
            animator.SetInteger("New Int", 1);
        }

        if (Input.GetKeyUp(KeyCode.I)){
            animator.SetInteger("New Int", 0);
        }

        if (Input.GetKeyDown(KeyCode.B)){
            animator.SetBool("New Bool", true);
        }

        if (Input.GetKeyUp(KeyCode.B)){
            animator.SetBool("New Bool", false);
        }

        if (Input.GetKeyDown(KeyCode.T)){
            animator.SetTrigger("New Trigger");
        }
    }
}
