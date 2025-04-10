using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Cinemachine;
using static UnityEditor.PlayerSettings;

public class Spawnnner : MonoBehaviour
{
    public GameObject prefab;
    public CinemachineCollisionImpulseSource impulsesource;
    void Start()
    {
        
    }

    
    void Update()
    {

        Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newThing = Instantiate(prefab, mouse, Quaternion.identity);
            impulsesource.GenerateImpulse();
            Destroy(newThing, 5);
        }
    }
}
