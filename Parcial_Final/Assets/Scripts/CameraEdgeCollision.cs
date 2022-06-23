using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEdgeCollision : MonoBehaviour
{
    private void Awake()
    {
        AddCollider();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddCollider()
    {
        if (Camera.main==null)
        {
            Debug.Log("no camera Main");
            return;
        }
        Camera cam = Camera.main;
        if (!cam.orthographic)
        {
            Debug.LogError("no es camera ortografica");
            return;
        }
        var edgeCollider = gameObject.GetComponent<EdgeCollider2D>() == null ? gameObject.AddComponent<EdgeCollider2D>() : gameObject.GetComponent<EdgeCollider2D>();
        var leftBotton = (Vector2)cam.ScreenToWorldPoint(new Vector3(0, 0, cam.nearClipPlane));
        var leftTop = (Vector2)cam.ScreenToWorldPoint(new Vector3(0, cam.pixelHeight, cam.nearClipPlane));
        var rightBotton = (Vector2)cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth, cam.pixelHeight, cam.nearClipPlane));
        var rightTop = (Vector2)cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth, 0, cam.nearClipPlane));

        
        var edgePoints = new[] { leftBotton, leftTop+new Vector2(0,1), rightBotton + new Vector2(0, 1), rightTop, leftBotton};
        edgeCollider.points = edgePoints;
    }
}

