using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paralax : MonoBehaviour
{

    [SerializeField] private float paralaxmultiplaier;
    private Transform cameratransform;
    private Vector3 lastcameraposiion;

    private void Start()
    {
        cameratransform = Camera.main.transform;
        lastcameraposiion = cameratransform.position;
    }
    private void Update()
    {
        Vector3 deltapMovment = cameratransform.position - lastcameraposiion;
        
        transform.position += deltapMovment * paralaxmultiplaier;
        lastcameraposiion = cameratransform.position;
    }

}
