using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMenu : MonoBehaviour
{
    public void SartGame()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
