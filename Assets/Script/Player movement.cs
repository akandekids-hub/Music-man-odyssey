using System;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [SerializeField] float movespeed = 5f;
    [SerializeField] float xClamp = 3f;
    [SerializeField] float zClamp = 3f;

    Vector2 movement;
    Rigidbody rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        movement = new Vector2(horizontal, vertical);

        HandleMovement();

    }

    void HandleMovement()
    {
        Vector3 currentPositon = rb.position;
        Vector3 moveDirecttion = new Vector3(movement.x, 0f, movement.y);
        Vector3 newPosition = currentPositon + moveDirecttion * (movespeed * Time.fixedDeltaTime);

        newPosition.x = Mathf.Clamp(newPosition.x, -xClamp, xClamp);
        newPosition.x = Mathf.Clamp(newPosition.z, -zClamp, zClamp);

        rb.MovePosition(newPosition);
    }
}
