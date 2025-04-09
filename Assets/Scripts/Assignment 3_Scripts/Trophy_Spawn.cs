using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trophy_Spawn : MonoBehaviour
{
    public GameObject prefab;
    public Button buttonColourChange;
   
    public void spawn()
    {
        GameObject newTrophy = Instantiate(prefab, Random.insideUnitCircle*8, transform.rotation);
        trophy Trophy = newTrophy.GetComponent<trophy>();

        buttonColourChange.onClick.AddListener(Trophy.ChangeColour);
    }
}
