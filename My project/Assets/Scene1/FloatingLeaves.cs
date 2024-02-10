using UnityEngine;
using UnityEngine.UI;

public class FloatingLeaves : MonoBehaviour
{
    public GameObject leafPrefab; // Prefab for the leaf GameObject
    public int numberOfLeaves = 10; // Number of leaves to instantiate
    public float floatSpeed = 2f; // Speed of floating
    public float floatMagnitude = 0.5f; // Magnitude of floating

    private GameObject[] leaves; // Array to hold references to the instantiated leaves

    void Start()
    {
        leaves = new GameObject[numberOfLeaves]; // Initialize the leaves array
        
        // Instantiate leaves
        for (int i = 0; i < numberOfLeaves; i++)
        {
            GameObject leaf = Instantiate(leafPrefab, transform);
            leaf.transform.localPosition = new Vector3(Random.Range(-100f, 100f), Random.Range(-100f, 100f), 0f);
            leaves[i] = leaf;
        }
    }

    void Update()
    {
        // Iterate through the leaves and apply floating effect
        for (int i = 0; i < numberOfLeaves; i++)
        {
            // Calculate the floating effect using Sine function
            float newY = Mathf.Sin(Time.time * floatSpeed + i) * floatMagnitude;
            // Update the position of the leaf
            leaves[i].transform.localPosition += new Vector3(0f, newY, 0f) * Time.deltaTime;
        }
    }
}
