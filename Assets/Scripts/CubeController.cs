using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{    

    public float fireRate;
    public int ObjectCount;
    public Vector3 target;
    private List<GameObject> objPool;
    private float dt;
    //private int currentBullet;

    private void Start()
    {
        //currentBullet = 0;
        objPool = new List<GameObject>(5);

        for (int i = 0; i < ObjectCount; i++)
        {
            GameObject _newBullet = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _newBullet.SetActive(false);
            _newBullet.AddComponent<Bullet>();
            objPool.Add(_newBullet);
        }
                

        foreach (GameObject item in objPool)
        {
            Debug.Log(item.name);
        }
    }

    


    private void Update()
    {

        //dt += Time.deltaTime;

        //if (dt>1/fireRate)
        //{            
        //    dt = 0;
        //}

    }

    



}
