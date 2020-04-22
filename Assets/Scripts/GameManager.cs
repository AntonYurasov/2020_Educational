using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class GameManager : MonoBehaviour
{

    public HintCube cubeController;

    // Start is called before the first frame update
    void Start()
    {
        #region out-параметр (посмотрите как работает)
        int value;

        GetInt(out value);

        Debug.Log(value);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        #region Нажатие клавиш клавиатуры        
        //if(Input.GetKeyUp(KeyCode.W))
        //{
        //    cubeController.ChangeMaterial();
        //}
        #endregion

        #region Обработка нажатия пробела для прыжка        
        //if(Input.GetButtonDown("Jump"))
        //{
        //    cubeController.ChangeMaterial();
        //}
        #endregion

        #region Получение осей        
        //float horizontalValue = Input.GetAxisRaw("Horizontal");
        //cubeController.Translate(horizontalValue);
        #endregion

        #region Нажатие кнопок мыши        
        //if(Input.GetMouseButtonDown(0))
        //{
        //    cubeController.ChangeMaterial();
        //}
        #endregion

        #region Перенос координат из пиксельных в абсолютные и в мировые
        //Vector3 viewPort = new Vector3(0.5f, 0.5f);
        //Screen to world point
        //Debug.DrawLine(Camera.main.transform.position, Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)));
        //cubeController.ChangePosition(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)));

        //Camera.main.ScreenPointToRay();

        //Vector3 direction = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)) - Camera.main.transform.position;

        //Ray _r = new Ray(Camera.main.transform.position, direction);
        #endregion

        #region RayCast

        //Рэйкаст в объекты сцены
        //if(Input.GetMouseButtonDown(0))
        //{
        //    Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);

        //    RaycastHit hit;

        //    if (Physics.Raycast(r, out hit))
        //    {
        //        Rigidbody _rigid = hit.transform.GetComponent<Rigidbody>();

        //        _rigid.AddForceAtPosition(Vector3.one * 20, hit.point, ForceMode.Impulse);
        //    }
        //}
        #endregion

    }


    private int GetInt(out int value)
    {
        value = 10;
        return 3;
    }
}
