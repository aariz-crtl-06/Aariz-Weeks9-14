using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class poster_change : MonoBehaviour
{
    //References first and second sprite images and the poster image
    public Sprite first;
    public Sprite second;
    public Image poster;

    
    //Function that makes second poster appear when mouse is over the base
    public void mouseOver()
    {
        poster.sprite = second;
    }
    //Function that makes second poster appear when mouse isn't over the base
    public void mouseNotOver()
    {
        poster.sprite = first;
    }
}
