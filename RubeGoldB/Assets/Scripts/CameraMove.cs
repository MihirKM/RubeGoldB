/**************************
Camera movement script
Made by Mihir
9/10/2021
**************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Class variable area
    [Tooltip("Drag object to follow here.")]
    public GameObject Target;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        // Check target is set
        if(Target != null)
        {
            Vector3 newPos = Target.transform.position;
            newPos.z = transform.position.z;
            transform.position = newPos;
        }
    }
}
