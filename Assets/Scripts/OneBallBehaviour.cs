using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneBallBehaviour : MonoBehaviour
{
     public bool DrawLine = false;
     public bool DrawRay = false;
     public float XRotation = 0;
     public float YRotation = 1;
     public float ZRotation = 0;
     public float DegreePerSecond = 180;

     static int BallCount = 0;
     public int BallNumber = 0;

     // Start is called before the first frame update
     void Start()
    {
          BallNumber = ++BallCount;
          transform.position = new Vector3(3 - Random.value * 6, 3 - Random.value * 6, 3 - Random.value * 6);
     }

    // Update is called once per frame
    void Update()
    {
          Vector3 axis = new Vector3(XRotation, YRotation, ZRotation);
          transform.RotateAround(Vector3.zero, axis, DegreePerSecond * Time.deltaTime);

          if (DrawLine)
          {
               Debug.DrawLine(this.transform.position, Vector3.zero, Color.red, 0.5f * Time.deltaTime);
          }
          if (DrawRay)
          {
               Debug.DrawRay(this.transform.position, axis, Color.yellow);
               Debug.DrawRay(Vector3.zero, axis, Color.yellow);
          }
     }
}
