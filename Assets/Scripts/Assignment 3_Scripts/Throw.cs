using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    //References bowling ball object
    public GameObject ball;
    //Score variable
    public float score;

    //References buttons to control trophies
    public GameObject button1;
    public GameObject button2;
    void Start()
    {
        
    }

    void Update()
    {
        //If 'G' is pressed, it'll play a coroutine 
        if(Input.GetKeyDown(KeyCode.G))
        {
            StartCoroutine(bowl());
        }

        //Once the score reaches 3, 2 buttons will active in the scene
        if (score == 3)
        {
            button1.SetActive(true);
            button2.SetActive(true);
        }
    }
    //coroutine that makes bowl animation play for 3 seconds then it's set off, also adds one to score
    private IEnumerator bowl()
    {
        ball.SetActive(true);
        yield return new WaitForSeconds(3);
        ball.SetActive(false);
        score+= 1;

    }

}
