using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool alreadyOver = false;
	public GameObject completeLevelUI;

    public void EndGame()
	{
		if (!alreadyOver)
		{
			alreadyOver = true;
			Debug.Log("game over");
			Invoke("Restart", 2f);
		}

	}

    public void CompleteLevel()
	{
		completeLevelUI.SetActive(true);
	}

    void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
