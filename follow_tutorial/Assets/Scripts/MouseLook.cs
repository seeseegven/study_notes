using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    // Start is called before the first frame update
  
        public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
        public RotationAxes axes = RotationAxes.MouseXAndY;

    // Update is called once per frame
    void Update()
    {
        if (axes == RotationAxes.MouseXAndY)
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");
            transform.Rotate(0, mouseX, 0);
            transform.Rotate(-mouseY, 0, 0);
        }
        else if (axes == RotationAxes.MouseX)
        {
            float mouseX = Input.GetAxis("Mouse X");
            transform.Rotate(0, mouseX, 0);
        }
        else if (axes == RotationAxes.MouseY)
        {
            float mouseY = Input.GetAxis("Mouse Y");
            transform.Rotate(-mouseY, 0, 0);
        }
    }
}
