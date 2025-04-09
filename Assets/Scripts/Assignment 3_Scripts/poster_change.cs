using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class poster_change : MonoBehaviour
{
    public Sprite first;
    public Sprite second;
    public Image poster;

    

    public void mouseOver()
    {
        poster.sprite = second;
    }

    public void mouseNotOver()
    {
        poster.sprite = first;
    }
}
