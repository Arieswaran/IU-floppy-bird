using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    public float x = 0, y = 0, z = 0;

    public RectTransform rectTransform;
    private void Start() {
        if (rectTransform == null) {
            rectTransform = GetComponent<RectTransform>();
        }
    }

    private void Update() {
        rectTransform.Rotate(x, y, z);
    }
}
