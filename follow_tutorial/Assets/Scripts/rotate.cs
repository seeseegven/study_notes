using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public float ratate_speed = 3f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, ratate_speed, 0, Space.Self);
        
    }
}
