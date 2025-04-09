using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creepy_guy : MonoBehaviour
{
    public GameObject mr_menace;

    public void menace()
    {
        StartCoroutine(menacing());
    }

    private IEnumerator menacing()
    {
        mr_menace.SetActive(true);
        yield return new WaitForSeconds(5);
        mr_menace.SetActive(false);
    }
}
