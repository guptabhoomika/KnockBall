using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public GameObject gameOver;

	bool gameHasEnded = false;
    public AudioSource bgSound;
    public AudioSource gameEnd;
	public GameObject completeLevelUI;

    public string level;

	public void CompleteLevel ()
	{
		completeLevelUI.SetActive(true);
	}

	public void EndGame ()
	{
		if (gameHasEnded == false)
		{
			gameHasEnded = true;
            gameEnd.Play();
			Debug.Log("GAME OVER");
            bgSound.Pause();
            gameOver.SetActive(true);
		}
	}

	public void Restart ()
	{
		SceneManager.LoadScene(level);
	}
    public void quit()
    {
        Application.Quit();
    }

}
