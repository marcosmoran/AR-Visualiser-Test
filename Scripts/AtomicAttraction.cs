using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomicAttraction : MonoBehaviour
{
    public GameObject _atom, _attractor;
    public Gradient _gradient;
    public int[] _attractPoints;
    public Vector3 _spacingDirection;
    [Range(0,20)]
    public float _spacingBetweenAttractPoints;
    [Range(0, 20)]
    public float _scaleAttractPoints;


    //visualises the attraction points on scene window and allows for ease of manipulating them
    private void OnDrawGizmos()
    {
        for( int i = 0; i < _attractPoints.Length; i++)
        {
            //colour the instanced objects
            float evaluateStep = 1.0f / _attractPoints.Length;
            Color color = _gradient.Evaluate(evaluateStep * i);
            Gizmos.color = color;
            Vector3 pos = new Vector3(transform.position.x + (_spacingBetweenAttractPoints * i * _spacingDirection.x),
                                      transform.position.y + (_spacingBetweenAttractPoints * i * _spacingDirection.y),
                                      transform.position.z + (_spacingBetweenAttractPoints * i * _spacingDirection.z));
            Gizmos.DrawSphere(pos, _scaleAttractPoints);

        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
