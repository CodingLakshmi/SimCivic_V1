using System;
using Unity.Netcode;
using UnityEngine;

public class FredBehavior : NetworkBehaviour
{
   void Update()
   {
       if (IsServer)
       {
           float theta = Time.time;
           transform.position = new Vector3((float) Math.Cos(theta) * 2f, 5.0f, (float) Math.Sin(theta));
       }
   }
}