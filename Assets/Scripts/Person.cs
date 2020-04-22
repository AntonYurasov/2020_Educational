using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{

    private Rigidbody _rig;

    // Start is called before the first frame update
    void Start()
    {
        _rig = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Установка скорости
        //_rig.velocity = Vector3.forward;
    }



    private void OnMouseDown()
    {
        _rig.AddForce(Vector3.forward*10, ForceMode.Impulse);
    }
}
