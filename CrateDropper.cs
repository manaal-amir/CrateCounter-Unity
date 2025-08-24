using UnityEngine;

public class CrateDropper : MonoBehaviour
{
    public GameObject cratePrefab; // Assign your crate prefab in Inspector
    public float dropInterval = 2f; // Drop every 2 seconds
    public Transform dropPoint; // Empty object under plane where crates drop

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= dropInterval)
        {
            Instantiate(cratePrefab, dropPoint.position, Quaternion.identity);
            timer = 0;
        }
    }
}
