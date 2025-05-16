using UnityEngine;
using UnityEngine.SceneManagement;  // Necesario para manejar escenas

public class SceneSwitcher : MonoBehaviour
{
    // Método público para cargar una escena
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}