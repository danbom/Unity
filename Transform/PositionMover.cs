using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionMover : TransformController
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePosition(new Vector3(0f, 0.1f, 0f)); // y좌표가 0.1에 고정된다
    }
}
