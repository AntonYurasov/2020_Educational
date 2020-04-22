using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    private Rigidbody _rigid;
    private Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
         _rigid = this.GetComponent<Rigidbody>();
        position = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        _rigid.velocity = new Vector3(Vector3.left.x*5, _rigid.velocity.y, _rigid.velocity.z);


        if(Input.GetButtonDown("Jump"))
        {
            _rigid.velocity = Vector3.zero;
            _rigid.AddForce(Vector3.up*5, ForceMode.Impulse);
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.CompareTag("TriggerPortal"))
    //    {
    //        _rigid.useGravity = false;
    //        _rigid.isKinematic = true;

    //        this.transform.position = position;

    //        _rigid.useGravity = true;
    //        _rigid.isKinematic = false;
    //    }
    //}
}
