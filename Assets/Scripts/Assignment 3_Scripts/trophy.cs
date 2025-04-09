using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;

public class trophy : MonoBehaviour
{
    //Referencing sprite renderer
    SpriteRenderer sr;

    //Adds on click event to the object in inspector
    public UnityEvent OnClick;
    void Start()
    {
        //Connects variable to sprite renderer in inspector
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        //When mouse is left clicked on trophy, it'll inovke the function of choice (shrink)
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(sr.bounds.Contains(mousePos))
            {
                OnClick.Invoke();
            }
        }

        
    }
    //Randomly changes colour of trophy
    public void ChangeColour()
    {
        sr.color = Random.ColorHSV();
    }
    //Shrinks trophy on click
    public void move()
    {
        transform.localScale -= Vector3.one*0.1f;
    }

}
