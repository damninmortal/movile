using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxFollowCamera : MonoBehaviour
{
    [SerializeField] private Transform _targetTransform;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (_targetTransform.position.y>transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, _targetTransform.position.y, transform.position.z);      
        }
        else if (_targetTransform.position.y < transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, _targetTransform.position.y, transform.position.z);
        }
    }
}
