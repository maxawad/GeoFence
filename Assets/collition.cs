using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collition : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Fence") {
            print("zap enter");
        }
    }

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "Fence") {
            print("zap continues");
        }
    }

    private void OnTriggerExit(Collider other) {
    if (other.gameObject.tag == "Fence") {
            print("zap exit");
        }
    }
}
