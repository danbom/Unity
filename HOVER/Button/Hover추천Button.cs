using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hover추천Button : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public RectTransform Button;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData){
        Button.GetComponent<Animator>().Play("추천 Hover On");
    }

    public void OnPointerExit(PointerEventData eventData){
        Button.GetComponent<Animator>().Play("추천 Hover Off");
    }
}
