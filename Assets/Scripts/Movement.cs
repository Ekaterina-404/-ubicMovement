using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 _savedPosition;
    private Vector3 _offsetRight = new Vector3(0.01f, 0); 
    private Vector3 _offsetLeft = new Vector3(-0.01f, 0); //=-_offsetRight
    private Vector3 _offsetUp = new Vector3(0,0.01f); 
    private Vector3 _offsetDown = new Vector3(0,-0.01f); //=-_offsetUp
    //глобальная переменная
    void Update()
    {
        var transformCube = GetComponent<Transform>();
        //_savedPosition = transformCube.position + new Vector3(0.01f,0);
        //transformCube.position = _savedPosition;
        _savedPosition = transformCube.position;

        if (transformCube.position.x < 8)
        {
            transformCube.position = _savedPosition + new Vector3(0.01f, 0); //нужно убрать изменение по оси x
        }
        else if (transformCube.position.x > 8)
        {
            transformCube.position = _savedPosition + new Vector3(0, 0.01f);
        }
    }
}
