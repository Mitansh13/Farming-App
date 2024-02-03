// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;
// public class SceneLoader : MonoBehaviour
// {
//     public void LoadScene()
//     {
        
//         SceneManager.LoadScene("Scene1");
//     }
// }
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Attach this method to a UI button click event in the Unity Editor
    public void OnButtonClick()
    {
        LoadSceneWithDelay();
    }

    void LoadSceneWithDelay()
    {
        StartCoroutine(LoadSceneAfterDelay("Scene1", 1.0f)); // Adjust the delay (in seconds) as needed
    }

    IEnumerator LoadSceneAfterDelay(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);

        SceneManager.LoadScene(sceneName);
    }
}


