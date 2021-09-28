using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int damage = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            var mon = FindObjectOfType<Monster>(); // 씬 안에 있는 몬스터 컴포넌트 찾게함
            if (Attack(mon)){
                Destroy(mon.gameObject);
                Debug.Log("처치");
            } else {
                Debug.Log("남은 체력 : " + mon.hp);
            }
        }
    }

    public bool Attack(Monster monster){
        monster.hp -= damage;
        return monster.hp <= 0;
    }
}
