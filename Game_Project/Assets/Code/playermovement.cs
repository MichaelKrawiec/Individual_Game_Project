﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public float turnSpeed = 45;
    public float moveSpeed = 5;

    void FixedUpdate()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 direction = mousePosition - transform.position;
        float angle = Vector2.SignedAngle(Vector2.right, direction);
        Vector3 targetRotation = new Vector3(0, 0, angle);

        rb.MoveRotation(Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(targetRotation), turnSpeed * Time.deltaTime));
        rb.MovePosition(rb.position + ((Vector2)transform.right * moveSpeed * Time.deltaTime));
    }
}
