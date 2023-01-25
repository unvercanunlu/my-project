using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera camera;

    public float horizontalSpeed = 1f;
    public float verticalSpeed = 1f;

    private float rotationX = 0.0f;
    private float rotationY = 0.0f;

    void Start()
    {
    }

    void Update()
    {
        float mousePositionX = Input.GetAxis("Mouse X");
        float mousePositionY = Input.GetAxis("Mouse Y");

        mousePositionX *= this.horizontalSpeed;
        mousePositionY *= this.verticalSpeed;

        this.rotationY += mousePositionX;
        this.rotationX -= mousePositionY;

        this.rotationX = Mathf.Clamp(this.rotationX, -90, 90);
 
        this.camera.transform.eulerAngles = new Vector3(
            this.rotationX, 
            this.rotationY, 
            0.0f
        );
    }
}
