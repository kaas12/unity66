using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 speed = new Vector2(5, 5);
    public Transform ply;
    public Transform ShootingPoint;
    public GameObject Bullet;

    float PosX = 0f;
    float PosY = -4f;
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");


        Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY, 0);

        PosX = Mathf.Clamp(PosX + speed.x * inputX, -2.8f, 2.8f);
        PosY = Mathf.Clamp(PosY + speed.y * inputY, -4.5f, 0f);

        Vector3 position = new Vector3(PosX, PosY, 0);
        ply.transform.position = position;

        if (Input.GetKeyDown("space"))
        {
            Shoot();
        }

    }
    public void Shoot() {
        Instantiate(Bullet, ShootingPoint.position, ShootingPoint.rotation);
    }
}
