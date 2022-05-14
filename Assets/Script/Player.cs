using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float MoveSpeed { get; set; }

    private void Start()
    {
        MoveSpeed = 10f;
    }

    private void Update()
    {
        MovePosition();
    }

    private void MovePosition()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 position = transform.position;

        position.x += horizontal * Time.deltaTime * MoveSpeed;
        position.y += vertical * Time.deltaTime * MoveSpeed;

        transform.position = position;
    }
}