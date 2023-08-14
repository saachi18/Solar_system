using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
 //declaring a variable to select the rotation target
 // Start is called before the first frame update
public Transform target;
public int speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 //Rotate Around the first parameter target position
 //Rotate around needs second parameter about the axis or rotation 
 // Rotate around third parameter needed is the speed of rotation.
transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);   
    }
}
