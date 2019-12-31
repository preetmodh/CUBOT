using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{

	bool gameHasEnded = false;

	public float restartDelay = 100f;

	public GameObject completeLevelUI;

	public void CompleteLevel ()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

	public void EndGame ()
	{
		if (gameHasEnded == false)
		{
			gameHasEnded = true;
			Debug.Log("GAME OVER");
			Invoke("Restart", restartDelay);
		}
	}

	 public void Restart ()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void Nextlevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
