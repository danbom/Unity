using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CooldownTime : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textInfo;
    [SerializeField]
    private TextMeshProUGUI textCooldownTime;
    [SerializeField]
    private Image imageCooldownTime;
    [SerializeField]
    private string skillName;
    [SerializeField]
    private float maxCooldownTime;
    private float currentCooldownTime;
    private bool isCooldown;

    private void Awake() {
        SetCooldownIs(false);
    }

    /// <summary>
    /// 외부에서 스킬 사용 후 쿨타임을 적용할 때 호출하는 메소드
    /// </summary> 
    public void StartCooldownTime(){
        // 이미 스킬을 사용해서 쿨타임이 남아있으면 종료
        if ( isCooldown == true ){
            textInfo.text = $"쿨타임 안내 - {skillName} : {((int)currentCooldownTime)}초";
            return;
        }
        textInfo.text = $"'Lulu'는 {skillName}를 시전했다 !";
        StartCoroutine("OnCooldownTime", maxCooldownTime);
    }

    /// <summary>
    /// 실제 스킬의 쿨다운 타임을 제어하는 코루틴 메소드
    /// </summary>
    private IEnumerator OnCooldownTime(float maxCooldownTime){
        // 쿨다운 시간 저장
        currentCooldownTime = maxCooldownTime;

        SetCooldownIs(true);

        while ( currentCooldownTime > 0 ){
            currentCooldownTime -= Time.deltaTime;
            // Image UI의 fillAmount를 조절해 채워지는 이미지 모양 설정
            imageCooldownTime.fillAmount = currentCooldownTime / maxCooldownTime;
            // Text UI에 쿨다운 시간 표시
            textCooldownTime.text = currentCooldownTime.ToString("F1");

            yield return null;
        }

        SetCooldownIs(false);
    }

    private void SetCooldownIs(bool boolean){
        isCooldown = boolean;
        textCooldownTime.enabled = boolean;
        imageCooldownTime.enabled = boolean;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
