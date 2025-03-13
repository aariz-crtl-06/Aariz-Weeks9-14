using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BurgerEvent : MonoBehaviour
{
    public RectTransform burgah;
    public UnityEvent OnTimerFinished;
    public float timerLength = 3;
    public float t;

  public void MouseEnterImage()
    {
        Debug.Log("The mouse just entered the image hee hee!");
        burgah.localScale = Vector3.one * 1.2f;
    }

    public void MouseLeftImage()
    {
        Debug.Log("The mouse just left the image :(");
        burgah.localScale = Vector3.one;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        if(t>timerLength)
        {
            OnTimerFinished.Invoke();
            t = 0;
        }
    }
}
