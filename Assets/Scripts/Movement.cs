using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 _savedPosition;
    //private Vector3 _offset = new Vector3(0.01f,0);
    //область видимости метода Апдейта, глобальная переменная
    void Start()
    {
        
    }
    void Update()
    {
        var transformCube = GetComponent<Transform>();
        _savedPosition = transformCube.position + new Vector3(0.01f,0);
        transformCube.position = _savedPosition;

        if (transformCube.position.x > 8 && transformCube.position.y < -4)
        {
            transformCube.position = _savedPosition + new Vector3(0.01f, 0); //нужно убрать изменение по оси x
        }
        else if (transformCube.position.x > 8)
        {
            transformCube.position = _savedPosition + new Vector3(0, 0.01f);
        }
    }
}
