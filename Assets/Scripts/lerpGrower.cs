using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpGrower : MonoBehaviour
{
    public AnimationCurve curve;
    public float minSize = 0;
    public float maxSize = 1;
    public float t;

    void Start()
    {
        
    }

    void Update()
    {
        t += Time.deltaTime;

        transform.localScale = Vector3.Lerp(Vector3.one * minSize, Vector3.one * maxSize, curve.Evaluate(t));
    }
}
