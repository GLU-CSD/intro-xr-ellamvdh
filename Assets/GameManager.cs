using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private bool gameActive = true;
    private int score = 0;
    private float scoreTimer = 0f; // Timer om score te verhogen

    // UI om de score te laten zien
    [SerializeField] private TextMeshProUGUI scoreText;

    // UI die getoond wordt bij game over
    [SerializeField] private GameObject gameOverUI;

    public Health health;
    public Button button;

    private void Start()
    {
        scoreText.text = "Score: " + score;
    }
    void Update()
    {
        if (gameActive)
        {
            //Time.deltaTime geeft aantal seconden sinds laatste Update
            scoreTimer += Time.deltaTime;

            if (scoreTimer >= 1f) // Verhoog de score elke seconde
            {
                score++;
                scoreText.text = "Score: " + score;
                scoreTimer = 0f; // Reset de timer
            }
        }
        else
        {
            Debug.Log("game is false");
        }






    }





    public void GameOver()
    {
        gameActive = false;

        // Vind alle vijanden in de scene
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        //Loop door alle gevonden vijanden en vernietig ze
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }

        // Doe hetzelfde met de spawners
        GameObject[] spawners = GameObject.FindGameObjectsWithTag("Spawner");
        foreach (GameObject spawner in spawners)
        {
            Destroy(spawner);
        }

        // Toon de Game Over UI
        gameOverUI.SetActive(true);
    }

    public void RestartGame()
    {
        Debug.Log("Restart was pressed");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   







}