using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DebugSkillinput : MonoBehaviour
{
    [SerializeField]
    private GraphicRaycaster graphicRaycaster;
    [SerializeField]
    private CooldownTime[] cooldownTime;

    private List<RaycastResult> raycastResults;
    private PointerEventData pointerEventData;

    private void Awake(){
        raycastResults = new List<RaycastResult>();
        pointerEventData = new PointerEventData(null);
    }

    // Update is called once per frame
    private void Update()
    {
        // for (int i = 0; i < cooldownTime.Length; ++ i){
        //     if (Input.GetKeyDown((i+1).ToString())){
        //         cooldownTime[i].StartCooldownTime();
        //     }
        // }

        if (Input.GetKeyDown(KeyCode.Q)){
            cooldownTime[0].StartCooldownTime();
        } 

        if (Input.GetKeyDown(KeyCode.W)){
            cooldownTime[1].StartCooldownTime();
        }

        if (Input.GetKeyDown(KeyCode.E)){
            cooldownTime[2].StartCooldownTime();
        }

        if (Input.GetKeyDown(KeyCode.R)){
            cooldownTime[3].StartCooldownTime();
        }

        // 스킬 아이콘을 마우스로 클릭해서 스킬 시전
        if (Input.GetMouseButtonDown(0)){
            raycastResults.Clear();

            pointerEventData.position = Input.mousePosition;
            graphicRaycaster.Raycast(pointerEventData, raycastResults);

            if ( raycastResults.Count > 0){
                // as CooldownTime으로 형 변환을 시도해 만약 스킬이 아닌 다른 UI를 눌렀다면 null이 저장되도록 한다.
                CooldownTime cool = raycastResults[0].gameObject.GetComponent<CooldownTime>() as CooldownTime;
                if ( cool != null ){
                    cool.StartCooldownTime();
                }
            }
        }
    }
}
