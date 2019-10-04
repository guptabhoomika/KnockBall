using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public GameObject gameOver;

	bool gameHasEnded = false;

	public float restartDelay = 1f;

	public GameObject completeLevelUI;

	public void CompleteLevel ()
	{
		completeLevelUI.SetActive(true);
	}

	public void EndGame ()
	{
		if (gameHasEnded == false)
		{
			gameHasEnded = true;
			Debug.Log("GAME OVER");
            gameOver.SetActive(true);
		}
	}

	public void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
    public void quit()
    {
        Application.Quit();
    }

}
