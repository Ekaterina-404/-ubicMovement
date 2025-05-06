using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class DiagonalMovement : MonoBehaviour
{
    private Vector3 _savedPosition;
    private bool _isFirstStage;
    private bool _isSecondStage;

    private Vector3 _offsetRight = new Vector3(0.03f, 0);
    private Vector3 _offsetLeft = new Vector3(-0.03f, 0); //=-_offsetRight
    private Vector3 _offsetUp = new Vector3(0, 0.03f);
    private Vector3 _offsetDown = new Vector3(0, -0.03f); //=-_offsetUp
    private Vector3 _offsetDiagonalUpLeft = new Vector3(-0.03f, 0.03f);
    private Vector3 _offsetDiagonalUpRight = new Vector3(0.03f, 0.03f);

    private void Start()
    {
        _isFirstStage = true;
    }

    void Update()
    {
        var transformCube = GetComponent<Transform>();
        _savedPosition = transformCube.position;

        if (_isFirstStage)
        {
            if (transformCube.position.x <= 8 && transformCube.position.y <= -4) //по границе, рабочая
            {
                Debug.Log(1);
                transformCube.position = _savedPosition + new Vector3(0.03f, 0);
            }
            else if (transformCube.position.x >= -8 && transformCube.position.y >= -4) //диагональ чееткая, рабочая
            {
                Debug.Log(2);
                transformCube.position = _savedPosition + new Vector3(-0.03f, 0.015f);
            }
            else if (transformCube.position.x <= -8 && transformCube.position.y >= -4) //по границе
            {
                Debug.Log(3);
                transformCube.position = _savedPosition + new Vector3(0, -0.03f);
                
                
            }
        }
        else if (_isSecondStage)
        {
            
            
        }
    }
}