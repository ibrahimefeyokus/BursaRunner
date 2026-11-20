using UnityEngine;
public class GroundLoop : MonoBehaviour
{
    public float speed = 5f;
    float width;
    void Start() { width = 19f; } // iki zemin arasý mesafe
    void Update()
    {
        if (!PlayerController.isRunningNow) return;
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x <= -width)
            transform.position += new Vector3(width * 2, 0, 0);
    }
}