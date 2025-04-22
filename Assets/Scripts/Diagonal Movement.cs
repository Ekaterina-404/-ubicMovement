using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class DiagonalMovement : MonoBehaviour
{
    private Vector3 _savedPosition;
    private Vector3 _offsetRight = new Vector3(0.01f, 0);
    private Vector3 _offsetLeft = new Vector3(-0.01f, 0); //=-_offsetRight
    private Vector3 _offsetUp = new Vector3(0, 0.01f);
    private Vector3 _offsetDown = new Vector3(0, -0.01f); //=-_offsetUp
    private Vector3 _offsetDiagonalUpLeft = new Vector3(-0.01f, 0.01f);

    //глобальная переменная
    void Update()
    {
        var transformCube = GetComponent<Transform>();
        _savedPosition = transformCube.position;

        if (transformCube.position.x <= 8 & transformCube.position.y >= -4) // норм
        {
            transformCube.position = _savedPosition + _offsetRight;
        }
        else if (transformCube.position.x >= 8 & transformCube.position.y <= 4)
        {
            transformCube.position = _savedPosition + _offsetDiagonalUpLeft;
        }
        else if (transformCube.position.x >= -8 & transformCube.position.y >= 4)
        {
            transformCube.position = _savedPosition + _offsetLeft;
        }
        else if (transform.position.x <= -8 & transformCube.position.y >= -4)
        {
            transformCube.position = _savedPosition + _offsetDown;
        }
    }
}