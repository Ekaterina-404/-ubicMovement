using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class DiagonalMovement : MonoBehaviour
{
    [SerializeField] private Vector3[] _points = new Vector3[9];
    private float _timeElapsed;
    private float _speed = 2;
    private int _currentIndex;

    private void Start()
    {
        var transformCube = GetComponent<Transform>();
        transformCube.position = _points[_currentIndex];
    }

    private void Update()
    {

        if (_timeElapsed < _speed)
        {
            transform.position = Vector3.Lerp(_points[_currentIndex], _points[_currentIndex + 1], _timeElapsed / _speed);
            _timeElapsed += Time.deltaTime;
        }

        if (_timeElapsed >= _speed)
        {
            _currentIndex++;

            if (_currentIndex >= _points.Length - 1)
            {
                _currentIndex = 0;
            }

            _timeElapsed = 0;
        }
    }
}