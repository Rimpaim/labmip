using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
   private void OnCollisionEnter(Collision collision)
   {
      Ball b = collision.gameObject.GetComponent<Ball>();

      if (b != null)
      {
         GameManager.Instance.PlayScore += b.Point;
         Destroy(b.gameObject);
      }
   }
}
