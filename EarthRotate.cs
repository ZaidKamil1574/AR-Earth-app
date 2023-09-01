using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame. if app runs on 60 frames - 60 times per second
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0,1,0)); //access sphere rotate property. rotate y component. vector 3 to pass 3D rotations



    }
}
