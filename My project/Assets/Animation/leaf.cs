using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaf : MonoBehaviour
{
    public GameObject leafPrefab; // Reference to the leaf prefab
    public float fallSpeed = 2f; // Adjust the speed of falling leaves
    public float rotationSpeed = 50f; // Adjust the rotation speed of falling leaves
    public float destroyYPosition = -5f; // Adjust the Y position to destroy the leaf

    void Start()
    {
        // Start the falling loop
        InvokeRepeating("SpawnLeaf", 0f, 1f); // Spawn a new leaf every 1 second (adjust as needed)
    }

    void SpawnLeaf()
    {
        // Instantiate a new leaf at a random X position at the top of the screen
        float randomX = Random.Range(-5f, 5f); // Adjust the X-axis range
        GameObject newLeaf = Instantiate(leafPrefab, new Vector3(randomX, 10f, 0f), Quaternion.identity);

        // Set the leaf's falling and rotation speeds
        newLeaf.GetComponent<leaf>().fallSpeed = fallSpeed;
        newLeaf.GetComponent<leaf>().rotationSpeed = rotationSpeed;
    }

    void Update()
    {
        // Move the leaf downwards
        transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);

        // Rotate the leaf
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

        // If the leaf goes below a certain Y position, destroy it and spawn a new one
        if (transform.position.y < destroyYPosition)
        {
            Destroy(gameObject);
            SpawnLeaf();
        }
    }
}


