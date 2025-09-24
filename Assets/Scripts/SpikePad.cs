using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPad : MonoBehaviour
{
    public Transform respawnPoint;   // Drag an empty "RespawnPoint" here

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;

        // zero out motion
        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
        if (rb) rb.linearVelocity = Vector2.zero;

        // move to respawn
        if (respawnPoint != null)
            collision.gameObject.transform.position = respawnPoint.position;
        else
            collision.gameObject.transform.position = Vector3.zero; // fallback if not set
    }
}

