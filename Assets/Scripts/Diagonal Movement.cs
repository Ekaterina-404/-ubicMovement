using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class DiagonalMovement : MonoBehaviour
{
    private Vector3 _savedPosition;
    private Vector3 _firstPoint;
    [SerializeField] private Vector3[] _points = new Vector3[4];

    //private Vector3 _offsetRight = new Vector3(0.03f, 0);
    //private Vector3 _offsetLeft = new Vector3(-0.03f, 0); //=-_offsetRight
    //private Vector3 _offsetUp = new Vector3(0, 0.03f);
    //private Vector3 _offsetDown = new Vector3(0, -0.03f); //=-_offsetUp
    //private Vector3 _offsetDiagonalUpLeft = new Vector3(-0.03f, 0.03f);
    //private Vector3 _offsetDiagonalUpRight = new Vector3(0.03f, 0.03f);

    private void Start()
    {
    }

    void Update()
    {
        var transformCube = GetComponent<Transform>();
        _savedPosition = transformCube.position;
    }

    private void MoveToWithLerp(Vector3[] positions, float time)
    {
        for (int i = 0; i < positions.Length; i++)
        {
            _firstPoint = transform.position;
            float t = 0f;

            while (t < 1)
            {
                t += Time.deltaTime / time;
                transform.position = Vector3.Lerp(_firstPoint, positions[i], t);
                //yield return null;
            }

            transform.position = positions[i];
        }
    }
}
        
   
