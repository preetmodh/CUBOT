
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
   public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

