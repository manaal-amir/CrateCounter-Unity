using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public float speed = 5f;
    public float moveRange = 8f; 
    private float startX;

    void Start()
    {
        startX = transform.position.x;
    }

    void Update()
    {
        
        float newX = startX + Mathf.Sin(Time.time * speed) * moveRange;
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
