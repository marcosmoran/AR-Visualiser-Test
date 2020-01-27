using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractTo : MonoBehaviour
{
    Rigidbody _rigidbody;
    public Transform _attractedTo;
    public float _strengthOfAttraction, _maxMagnitude;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody> ();

    }

   
    void Update()
    {
        if (_attractedTo != null)
        {
            //direction of applied force
            Vector3 direction = _attractedTo.position - transform.position;
            _rigidbody.AddForce(_strengthOfAttraction * direction);
           
            // limit magnitude
            if(_rigidbody.velocity.magnitude > _maxMagnitude)
            {
                _rigidbody.velocity = _rigidbody.velocity.normalized * _maxMagnitude;
            }
        
        
        }
    }
}
