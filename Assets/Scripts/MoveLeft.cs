using UnityEngine;
public class MoveLeft : MonoBehaviour
{
    public float speed = 8f;
    void Update()
    {
        if (!PlayerController.isRunningNow) return; // koþmuyorsa dur
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x < -12f) Destroy(gameObject);
    }
}