using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateMover : TransformController
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveTranslate(new Vector3(0f, 0.1f, 0f)); // 쭉 올라간다
    }
}
