using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (_playerTransform.position.x>transform.position.x)
        {
            transform.position = new Vector3(_playerTransform.position.x, transform.position.y, transform.position.z);      
        }
        else if (_playerTransform.position.x < transform.position.x)
        {
            transform.position = new Vector3(_playerTransform.position.x, transform.position.y, transform.position.z);
        }
    }
}
