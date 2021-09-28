using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) {
        Debug.Log("Enter");
    }

    private void OnCollisionStay(Collision collision) {
        Debug.Log("Stay");
    }

    private void OnCollisionExit(Collision collision) {
        Debug.Log("Exit");
    }

    private void OnTriggerEnter(Collider collider) {
        Debug.Log("Trigger Enter");
    }

    private void OnTriggerStay(Collider collider) {
        Debug.Log("Trigger Stay");
    }

    private void OnTriggerExit(Collider collider) {
        Debug.Log("Trigger Exit");
    }
}
