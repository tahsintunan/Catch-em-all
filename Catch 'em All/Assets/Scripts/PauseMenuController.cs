using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameSession gameSession;
    private bool _gameIsPaused;
    
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && gameSession.health > 0)
            TogglePauseMenu();
    }

    private void TogglePauseMenu()
    {
        if (_gameIsPaused)
            Resume();
        else
            Pause();
    }

    private void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        _gameIsPaused = false;
    }

    private void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        _gameIsPaused = true;
    }

}
