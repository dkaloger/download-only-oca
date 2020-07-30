using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
  public  Transform gunObj;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                // Find the line from the gun to the point that was clicked.
                Vector3 incomingVec = hit.point - gunObj.position;

                // Use the point's normal to calculate the reflection vector.
                Vector3 reflectVec = Vector3.Reflect(incomingVec, hit.normal);

                // Draw lines to show the incoming "beam" and the reflection.
                Debug.DrawLine(gunObj.position, hit.point, Color.red);
                Debug.DrawRay(hit.point, reflectVec, Color.green);
            }
        }
    }
}
