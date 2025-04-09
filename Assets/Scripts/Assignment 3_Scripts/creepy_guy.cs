using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creepy_guy : MonoBehaviour
{
    //This is a different script that is changed by the on trigger event within the posters, by clicking the poster, this function activates


    //References two game objects 
    public GameObject mr_menace;
    public GameObject mr_anger;
    //To track how many times first person pops up
    public float pop_up;

    //function that runs the coroutines to make one of the game objects activate on screen
    public void menace()
    {
        //Starts the first coroutine until the first one has been done 3 times
        if (pop_up <=2)
        {
            StartCoroutine(menacing());
        }
        //Starts the second coroutine after first one is done 3 times
        if (pop_up >=3)
        {
            StopCoroutine(menacing());
            StartCoroutine(anger());
        }

    }

    //Coroutune to activate character, stay for 5 seconds and deactivate, adds to pop up value
    private IEnumerator menacing()
    {
        mr_menace.SetActive(true);
        yield return new WaitForSeconds(5);
        mr_menace.SetActive(false);
        pop_up += 1;
    }
    //The coroutine for the second character
    private IEnumerator anger()
    {
        mr_anger.SetActive(true);
        yield return new WaitForSeconds(5);
        mr_anger.SetActive(false);
    }
}
