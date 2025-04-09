using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    public GameObject ball;
    public float score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            StartCoroutine(bowl());
        }

        if (score == 3)
        {
            celebration();
        }
    }

    private IEnumerator bowl()
    {
        ball.SetActive(true);
        yield return new WaitForSeconds(3);
        ball.SetActive(false);
        score+= 1;

    }

    private void celebration()
    {

    }
}
