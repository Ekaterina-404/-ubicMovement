using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class DiagonalMovement : MonoBehaviour
{
    //[SerializeField] private Vector3[] _points = new Vector3[9];
    //private static Vector3 _savedPosition;
    //private float speed = 2f;
    private static Vector3 _firstPosition = new Vector3(-8, -4);
    private static Vector3 _secondPosition = new Vector3(8, 4);
    float timeElapsed;
    float lerpDuration = 3;

    //float lerpedValue;

    void Start()
    {
        var transformCube = GetComponent<Transform>();
        transformCube.position = _firstPosition;
        //_savedPosition = transformCube.position;
    }

    void Update()
    {
        //MoveToWithLerp(_points, t);
        //private void MoveToWithLerp(Vector3[] positions, float time)

        //for (int i = 0; i < _points.Length; i++)
        //if (i == 0)


        if (timeElapsed < lerpDuration)
        {
            transform.position = Vector3.Lerp(_firstPosition, _secondPosition, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;
        }
    }
}