using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject winScreen;
    public TextMeshProUGUI enemyText;

    private int enemyCount;
    private bool gameWon = false;

    void Start()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

        UpdateEnemyText();

        if (winScreen != null)
            winScreen.SetActive(false);
    }

    public void EnemyDestroyed()
    {
        enemyCount--;
        UpdateEnemyText();


        if (enemyCount <= 0)
        {
            PlayerWins();
        }
    }

    void UpdateEnemyText()
    {
        if (enemyText != null)
            enemyText.text = "Enemies Left: " + enemyCount;
    }

    void PlayerWins()
    {
        if (!gameWon)
        {
            gameWon = true;

            if (winScreen != null)
                winScreen.SetActive(true);
        }
    }
}