using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetPanel : MonoBehaviour
{
    public GameObject resetPanel;

    // Bind this to Secondary Button on XR controller via Input Actions
    public void TogglePanel()
    {
        resetPanel.SetActive(!resetPanel.activeSelf);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}