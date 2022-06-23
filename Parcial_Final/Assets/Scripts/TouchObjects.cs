using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchObjects : MonoBehaviour
{
    public List<Sprite> objectList = new List<Sprite>();
    public GameObject objectBox;
    public float timeObjects;
    
    // Start is called before the first frame update
    void Start()
    {
        makeObject();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.touchCount>0&& Input.GetTouch(0).phase==TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;
            
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow, 100f);
            if (Physics.Raycast(ray,out hit))
            {
                if (hit.transform.tag=="Object")
                {
                    GameObject temp = hit.transform.gameObject;
                    GameManager.instance.AddLife();
                    GameManager.instance.nBombs++;
                    GameManager.instance.points += 5;
                    Destroy(temp);
                }
            }
            else
            {
                return;
            }
        }
    }
    private void makeObject()
    {
        Camera cam = Camera.main;
        var leftTop = (Vector2)cam.ScreenToWorldPoint(new Vector3(0, cam.pixelHeight, cam.nearClipPlane));
        var rightBotton = (Vector2)cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth, cam.pixelHeight, cam.nearClipPlane));
        float xRandom = Random.Range(leftTop.x+0.5f, rightBotton.x-0.5f);
        Vector3 objectsPos = new Vector3(xRandom, leftTop.y - 0.5f, 1f);
        
        objectBox.GetComponent<SpriteRenderer>().sprite = objectList[Random.Range(0, objectList.Count)];
        Instantiate(objectBox, objectsPos, transform.rotation);

        StartCoroutine(ObjectSpawn());
    }
    IEnumerator ObjectSpawn()
    {
        yield return new WaitForSeconds(timeObjects);
        makeObject();
        

    }
}
