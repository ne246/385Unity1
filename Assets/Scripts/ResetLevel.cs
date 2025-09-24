using UnityEngine;
// using UnityEngine.SceneManagement; // uncomment if you prefer reloading the scene

public class FallReset : MonoBehaviour
{
    public float killY = -10f;
    public Transform respawnPoint;   // drag an empty "RespawnPoint" here

    Rigidbody2D rb;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
        if (respawnPoint == null) {
            // default: start position
            GameObject p = new GameObject("DefaultRespawnPoint");
            respawnPoint = p.transform;
            respawnPoint.position = transform.position;
        }
    }

    void Update() {
        if (transform.position.y < killY) Respawn();
    }

    public void Respawn() {
        if (rb) rb.linearVelocity = Vector2.zero;
        transform.position = respawnPoint.position;

    }
}
