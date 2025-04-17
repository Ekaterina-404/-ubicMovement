using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 _savedPosition;
    private Vector3 _offset = new Vector3(0.001f,0);
    //область видимости Апдейта, глобальная переменная
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform transformCube = GetComponent<Transform>();
        _savedPosition = transformCube.position + _offset;
        transformCube.position = _savedPosition;
    }
}
