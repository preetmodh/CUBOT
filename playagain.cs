using UnityEngine;
using UnityEngine.SceneManagement;


public class playagain : MonoBehaviour
{
    public void PlayAgain ()
    {
        SceneManager.LoadScene("menu");
    }
}
