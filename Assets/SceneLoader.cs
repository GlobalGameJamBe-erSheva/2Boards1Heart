using UnityEngine;


public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    public void getTheHellOUt() {

        Application.Quit();
    }
}
