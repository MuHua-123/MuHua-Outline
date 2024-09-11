using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MuHua.Outline {
    public class ROOutline : MonoBehaviour {
        private void Awake() {
            ROControl.Enqueue(transform);
        }
        private void OnDestroy() {
            ROControl.Dequeue(transform);
        }
    }
}