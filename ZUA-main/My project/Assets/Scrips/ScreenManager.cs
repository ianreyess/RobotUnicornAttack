using UnityEngine;
using System.Collections;

public class SceneManagement : MonoBehaviour
{
    public void LoadScene (string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}

