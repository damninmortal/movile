using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private float _parallaxValue;

    public Transform cameraTransform;
    private Vector3 previousCameraPosition;
    private float spriteWidth, startPosition;
    // Start is called before the first frame update
    void Start()
    {
        //cameraTransform = Camera.main.transform;
        previousCameraPosition = cameraTransform.position;
        spriteWidth = GetComponent<SpriteRenderer>().bounds.size.y;
        startPosition = transform.position.y;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float deltax = (cameraTransform.position.y - previousCameraPosition.y) * _parallaxValue;
        float moveAmount = cameraTransform.position.y * (1 - _parallaxValue);
        transform.Translate(new Vector3(0, deltax, 0));
        previousCameraPosition = cameraTransform.position;

        if (moveAmount > startPosition + spriteWidth)
        {
            transform.Translate(new Vector3(0, spriteWidth, 0));
            startPosition += spriteWidth;
        }
        else if (moveAmount < startPosition - spriteWidth)
        {
            transform.Translate(new Vector3(0,-spriteWidth, 0));
            startPosition -= spriteWidth;
        }
    }
}
