using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ClliderController : MonoBehaviour
{
    private Transform pointA;
    private Transform pointB;
    
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.transform.name);
    }

    private GameObject a;
    private void Update()
    {
        #region Вращение объекта вокруг осей

        // var h = Input.GetAxisRaw("Horizontal");
        // a.transform.Rotate(Vector3.up*h);

        #endregion
      
        // Блок вращения объектов
        var h = Input.GetAxisRaw("Horizontal");


    }

   
    
    
}


public static class Ex
{
   public static Vector3 RandomPoint(Transform a, Transform b)
    {
        var _x = Random.Range(a.transform.position.x, b.transform.position.x);
        var _y = Random.Range(a.transform.position.y, b.transform.position.y);
        var _z = Random.Range(a.transform.position.z, b.transform.position.z);
        
        return new Vector3(_x,_y,_z);
    }

   public static bool ChkDistance(Transform a, Transform b, float dist)
   {
       return Vector3.Distance(a.transform.position, b.transform.position) < dist;
   }
}
