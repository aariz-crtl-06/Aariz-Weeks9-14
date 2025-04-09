using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creepy_guy : MonoBehaviour
{
    public GameObject mr_menace;
    public GameObject mr_anger;
    public float pop_up;

    public void menace()
    {
        if (pop_up <=2)
        {
            StartCoroutine(menacing());
        }
        if (pop_up >=3)
        {
            StopCoroutine(menacing());
            StartCoroutine(anger());
        }

    }

    private IEnumerator menacing()
    {
        mr_menace.SetActive(true);
        yield return new WaitForSeconds(5);
        mr_menace.SetActive(false);
        pop_up += 1;
    }

    private IEnumerator anger()
    {
        mr_anger.SetActive(true);
        yield return new WaitForSeconds(5);
        mr_anger.SetActive(false);
    }
}
