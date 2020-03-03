using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] Transform _target;
    [SerializeField] float _height = 10f;
    [SerializeField] float _offsetZ = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(_target.position.x, _height, _target.position.z - _offsetZ);
    }
}
