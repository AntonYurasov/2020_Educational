using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBirds : MonoBehaviour
{
    [SerializeField]
    private GameObject Bird;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = Bird.AddComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, _rigidbody.velocity.y, 1);

        if (Input.GetKeyDown(KeyCode.Insert))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetButtonDown("Jump"))
        {
            _rigidbody.velocity = Vector3.zero;
            _rigidbody.AddForce(Vector3.up*10,ForceMode.Impulse);
        }
    }
}
