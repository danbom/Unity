using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // AddSubVector();
        // MulVector();
        // VectorLength();
        // NormalizeVector();
        // DotVector();
        CrossVector();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void AddSubVector() {
        Vector3 v1 = new Vector3(1f,2f);
        Vector3 v2 = new Vector3(2f, 1f);

        Debug.Log("v1 + v2 = " + (v1 + v2));
        Debug.Log("v1 - v2 = " + (v1 - v2));
    }

    // 스칼라 곱
    private void MulVector() {
        Vector3 v1 = new Vector3(1f, 1f);
        float scalar = 4f;

        Debug.Log("4 * v1 = " + (scalar * v1));
    }

    // 벡터 길이 구하기
    private void VectorLength() {
        Vector3 v1 = new Vector3(2f, 2f);

        Debug.Log("Length of v1 = " + v1.magnitude);
    }

    // 벡터의 정규화
    private void NormalizeVector() {
        Vector3 v1 = new Vector3(2f, 2f);

        Debug.Log("Normalized v1 = " + v1.normalized);
        Debug.Log("Length of v1 = " + v1.normalized.magnitude);
    }

    // 벡터의 내적
    private void DotVector() {
        Vector3 v0 = new Vector3(2f, 0f);
        Vector3 v45 = new Vector3(1f, 1f);
        Vector3 v90 = new Vector3(0f, 2f);
        Vector3 v135 = new Vector3(-1f, 1f);

        Debug.Log("v0 . v45 = " + Vector3.Dot(v0, v45)); // 0 보다 크게
        Debug.Log("v0 . v90 = " + Vector3.Dot(v0, v90)); // 0
        Debug.Log("v0 . v135 = " + Vector3.Dot(v0, v135)); // 0 보다 작게

        Debug.Log("v0 to v45 angle = " + Vector3.Angle(v0, v45)); // 90도 보다 작게
        Debug.Log("v0 to v90 angle = " + Vector3.Angle(v0, v90)); // 90도
        Debug.Log("v0 to v135 angle = " + Vector3.Angle(v0, v135)); // 90도 보다 크게
    }

    // 벡터의 외적
    private void CrossVector() {
        Vector3 v1 = new Vector3(2, 0, 0);
        Vector3 v2 = new Vector3(0, 0, 2);

        Debug.Log("v1 x v2 = " + Vector3.Cross(v1, v2));
        Debug.Log(Vector3.Angle(v1, Vector3.Cross(v1, v2)));
        Debug.Log(Vector3.Angle(v2, Vector3.Cross(v1, v2)));
    }
}
