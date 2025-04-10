using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CircleFollow : MonoBehaviour
{
     SpriteRenderer sr;
    public TrailRenderer tr;

    public float t;
    

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        tr = GetComponent < TrailRenderer>();
    }


    void Update()
    {
        t += Time.deltaTime;
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        sr.color = Random.ColorHSV();
        tr.materials[0].color = Random.ColorHSV();
    }
}
