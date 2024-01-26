using UnityEngine;

public class LeafShake : MonoBehaviour
{
    public float shakeSpeed = 1.0f;   // Speed of the shake
    public float shakeAmount = 0.1f;  // Amount of shake

    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        // Calculate the shake effect using simple Mathf.Sin function
        float shakeX = Mathf.Sin(Time.time * shakeSpeed) * shakeAmount;
        float shakeY = Mathf.Sin(Time.time * shakeSpeed * 1.5f) * shakeAmount; // Use a different frequency for Y to make it more interesting

        // Apply the shake effect to the original position
        Vector3 newPosition = originalPosition + new Vector3(shakeX, shakeY, 0f);

        // Move the leaf
        MoveLeaf(newPosition);
    }

    private void MoveLeaf(Vector3 newPosition)
    {
        // Move the leaf to the new position
        transform.position = newPosition;
    }
}
