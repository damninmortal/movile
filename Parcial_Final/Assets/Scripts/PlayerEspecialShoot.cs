using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEspecialShoot : MonoBehaviour
{
    private Vector2 PosicionInicial;
    private Vector2 PosicionInicial2;
    public float SwipeMinY; //0.5
    public float SwipeMinX; //0.5
    public GameObject projectileEsp;
    

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                PosicionInicial = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                float swipeVertical = (new Vector3(0, touch.position.y, 0) - new Vector3(0, PosicionInicial.y, 0)).magnitude;
                if (swipeVertical > SwipeMinY)
                {


                    float u = Mathf.Sign(touch.position.y - PosicionInicial.y);
                    if (u > 0)
                    {
                        print("Arriba");//Arriba
                        if (GameManager.instance.nBombs>0)
                        {
                            GameManager.instance.nBombs--;
                            Instantiate(projectileEsp, transform.position, transform.rotation);
                        }
                       
                    }
                }
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            PosicionInicial2 = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
        }
        if (Input.GetMouseButtonUp(0))
        {
            float swipeVertical2 = (new Vector3(0, Input.mousePosition.y, 0) - new Vector3(0, PosicionInicial2.y, 0)).magnitude;
            float swipeHorizontal2 = (new Vector3(Input.mousePosition.x, 0, 0) - new Vector3(PosicionInicial2.x, 0, 0)).magnitude;

            if (swipeVertical2 > SwipeMinY && swipeVertical2 > swipeHorizontal2)
            {


                float u = Mathf.Sign(Input.mousePosition.y - PosicionInicial2.y);
                if (u > 0)
                {
                    print("Arriba Mouse");//Arriba
                    if (GameManager.instance.nBombs > 0)
                    {
                        Instantiate(projectileEsp, transform.position, transform.rotation);
                    }
                }              
            }
        }
    }
}
