using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turret : MonoBehaviour
{
    public GameObject turretBase;
    public GameObject turretBarrel;
    public GameObject bullet;
    public GameObject shotPoint;
    
    public Slider speedSlider;
    private float yRotation = 0;
    private float xRotation = 0;
    
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = speedSlider.value;
    }

    // Update is called once per frame
    void Update()
    {
        turretBase.transform.Rotate(0, yRotation*Time.deltaTime, 0);
        turretBarrel.transform.Rotate(xRotation*Time.deltaTime, 0, 0);
    }

    public void RotateLeft()
    {
        yRotation = -speed;
    }

    public void RotateStop()
    {
        yRotation = 0;
        xRotation = 0;
    }
    
    public void RotateRight()
    {
        yRotation = speed;
    }
    
    public void RotateUp()
    {
        xRotation = -speed;
    }

    public void RotateDown()
    {
        xRotation = speed;
    }
    
    public void SpeedUpdate()
    {
        speed = speedSlider.value;
    }

    public void Fire()
    {
        Instantiate(bullet, shotPoint.transform.position, turretBarrel.transform.rotation);
    }
}
