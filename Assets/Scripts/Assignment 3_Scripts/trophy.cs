using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;

public class trophy : MonoBehaviour
{

    SpriteRenderer sr;

    public UnityEvent OnClick;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(sr.bounds.Contains(mousePos))
            {
                OnClick.Invoke();
            }
        }

        
    }

    public void ChangeColour()
    {
        sr.color = Random.ColorHSV();
    }

    public void move()
    {
        transform.localScale -= Vector3.one*0.1f;
    }

}
