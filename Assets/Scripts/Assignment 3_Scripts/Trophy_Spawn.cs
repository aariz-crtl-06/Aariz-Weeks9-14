using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trophy_Spawn : MonoBehaviour
{
    //Referencing prefab from assets
    public GameObject prefab;
    //Referencing trophy colour change button
    public Button buttonColourChange;
   
    //function to cause trophies to spawn
    public void spawn()
    {
        //Instantiates the trophy prefab and allows it to spawn multiple
        GameObject newTrophy = Instantiate(prefab, Random.insideUnitCircle*8, transform.rotation);
        trophy Trophy = newTrophy.GetComponent<trophy>();
        //Adding a listener to allow for more trophies
        buttonColourChange.onClick.AddListener(Trophy.ChangeColour);
    }
}
