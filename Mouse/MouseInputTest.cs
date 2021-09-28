using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            Debug.Log("Down");
        }
        if (Input.GetMouseButton(0)){
            Debug.Log("Hold");
        }
        if (Input.GetMouseButtonUp(0)){
            Debug.Log("Up");
        }

        // Debug.Log(Input.mousePosition);

        // float value = Input.GetAxis("Mouse ScrollWheel");

        Vector2 scrollDelta = Input.mouseScrollDelta;

        if (scrollDelta.y > 0){
            Debug.Log("위로 " + scrollDelta); // 위로 (0.0, 1.0)
        }

        if (scrollDelta.y < 0){
            Debug.Log("아래로 " + scrollDelta); // 아래로 (0.0, -1.0)
        }


    }
}
