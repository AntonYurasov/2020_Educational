using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class HintCube: MonoBehaviour
    {


        private MeshRenderer meshR;
        private Color previousColor;

        private bool _K = false;

        //Invoke before first frame
        private void Start()
        {
            //Получение ссылки компонента MeshRenderer            
            meshR =  this.GetComponent<MeshRenderer>();

            previousColor = meshR.material.color;
        }

        public void ChangeMaterial()
        {    
            if(!_K)
            {
                meshR.material.color = Color.green;
                _K = true;
            }
            else
            {
                meshR.material.color = previousColor;
                _K = false;
            }
            
        }

        public void Translate(float value)
        {
            this.transform.Translate(Vector3.right * Time.deltaTime * value);
        }


        public void ChangePosition(Vector3 worldPoint)
        {
            this.transform.position = worldPoint;
        }

        //Every frame
        private void Update()
        {
             
        }

        //Наведение курсором на объект
        //private void OnMouseEnter()
        //{
        //    ChangeMaterial();
        //}







    }

}

