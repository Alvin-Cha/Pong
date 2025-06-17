using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class game_manager : MonoBehaviour
{
    public Image coin1, coin2, coin3;
    public Image skull1, skull2, skull3;

    private int livesPlayer1 = 3;
    private int livesPlayer2 = 3;

    // Called by Hitbox1
    public void LoseLifePlayer1()
    {
        livesPlayer1--;

        if (livesPlayer1 == 2)
            coin3.enabled = false;
        else if (livesPlayer1 == 1)
            coin2.enabled = false;
        else if (livesPlayer1 == 0)
        {
            coin1.enabled = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Or trigger Game Over
        }
    }

    // Called by Hitbox2
    public void LoseLifePlayer2()
    {
        livesPlayer2--;

        if (livesPlayer2 == 2)
            skull3.enabled = false;
        else if (livesPlayer2 == 1)
            skull2.enabled = false;
        else if (livesPlayer2 == 0)
        {
            skull1.enabled = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Or Game Over for P2
        }
    }
}
