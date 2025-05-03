using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class DiagonalMovement : MonoBehaviour
{
    private Vector3 _savedPosition;
    
    private Vector3 _offsetRight = new Vector3(0.03f, 0);
    private Vector3 _offsetLeft = new Vector3(-0.03f, 0); //=-_offsetRight
    private Vector3 _offsetUp = new Vector3(0, 0.03f);
    private Vector3 _offsetDown = new Vector3(0, -0.03f); //=-_offsetUp
    private Vector3 _offsetDiagonalUpLeft = new Vector3(-0.03f, 0.03f);
    private Vector3 _offsetDiagonalUpRight = new Vector3(0.03f, 0.03f);

    void Update()
    {
        var transformCube = GetComponent<Transform>();
        _savedPosition = transformCube.position;

        if (transformCube.position.x <= 8 && transformCube.position.y <= -4) //по границе, рабочая
        {
            transformCube.position = _savedPosition + new Vector3(0.03f, 0);
        }
        else if (transformCube.position.x >= -8 && transformCube.position.y >= -4) //диагональ чееткая, рабочая
        {
            transformCube.position = _savedPosition + new Vector3(-0.03f, 0.015f);
        }
        else if (transformCube.position.x <= -8 && transformCube.position.y >= -4) //по границе
        {
            transformCube.position = _savedPosition + new Vector3(0, -0.03f);
        }
        else if (transform.position.x <= -8 && transform.position.y <= -4) //диагональ, не работает
        {
            transformCube.position = _savedPosition + new Vector3(0.03f, 0.015f);
        }

        /*
        else if (transform.position.x >= 8) //по границе
        {
            transformCube.position = _savedPosition + _offsetLeft;
        }
       else if (transform.position.x <= -8) //по границе
        {
            transformCube.position = _savedPosition + _offsetLeft;
        }
        */
    }
}