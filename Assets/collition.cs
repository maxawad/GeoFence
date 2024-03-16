using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collition : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Zap") {
            print("zap enter");
        }
    }

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "Zap") {
            print("zap stay");
        }
    }

    private void OnTriggerExit(Collider other) {
    if (other.gameObject.tag == "Zap") {
            print("zap exit");
        }
    }
}
