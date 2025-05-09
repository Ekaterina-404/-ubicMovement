using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class DiagonalMovement : MonoBehaviour
{
    [SerializeField] private Vector3[] _points = new Vector3[9];
    float timeElapsed;
    float speed = 8;
    //private static Vector3 _savedPosition;

    void Start()
    {
        var transformCube = GetComponent<Transform>();
        transformCube.position = _points[0];
        //_savedPosition = transformCube.position;
    }

    void Update()
    {
        //MoveToWithLerp(_points, t);
        //private void MoveToWithLerp(Vector3[] positions, float time)

        for (int i = 0; i < _points.Length; i++)
        {
            if (timeElapsed < speed)
            {
                transform.position = Vector3.Lerp(_points[i], _points[i + 1], timeElapsed / speed);
                timeElapsed += Time.deltaTime;
            }
        }
    }
}
