using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class You_Peter_Move : MonoBehaviour
{
    public float speed = 5f;
    private CharacterController _controller;
    public float mouseSensitivity = 4f;

    // Start is called before the first frame update
    void Start()
    {
        _controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        MyRotate();
        Gravity();
    }

    void Movement()
    {
        //referencing the input axis from the input manager
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * verticalMove + transform.right * horizontalMove;
        _controller.Move(move * speed * Time.deltaTime);
    }

    void MyRotate()
    {
        //referencing the input axis from the input manager
        float horizontalRotation = Input.GetAxis("Mouse X");
        float verticalRotation = Input.GetAxis("Mouse Y");

        transform.Rotate(-1 * verticalRotation * mouseSensitivity, horizontalRotation * mouseSensitivity, 0);
    }

    void Gravity()
    {
        _controller.Move(Physics.gravity * Time.deltaTime);
    }
}
