using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class DiagonalMovement : MonoBehaviour
{
    private static Vector3 _firstPoint;
    [SerializeField] private Vector3[] _points = new Vector3[9];
    private static Vector3 _savedPosition;

    void Start()
    {
        var transformCube = GetComponent<Transform>();
        _savedPosition = transformCube.position;
        _firstPoint = _savedPosition;
    }

    void Update()
    {
        //MoveToWithLerp(_points, t);
        //private void MoveToWithLerp(Vector3[] positions, float time)

        float t = 0f;
        for (int i = 0; i < _points.Length; i++)
        {
            if (i == 0)
            {
                while (t < 1)
                {
                    t += Time.deltaTime / t;
                    yield return null;
                }
                
                var thisTransformCube = Vector3.Lerp(_firstPoint, _points[i], t);
                _savedPosition = thisTransformCube;
            }

            //transform.position = positions[i];
            //_firstPoint = transform.position;
        }
    }
}