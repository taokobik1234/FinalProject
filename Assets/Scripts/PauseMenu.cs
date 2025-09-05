using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    private bool isPaused = false;

    // Store the original cursor state to restore it properly
    private bool originalCursorVisible;
    private CursorLockMode originalCursorLockMode;

    void Start()
    {
        // Store the initial cursor state when the game starts
        originalCursorVisible = Cursor.visible;
        originalCursorLockMode = Cursor.lockState;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        // Restore the original cursor state
        Cursor.visible = originalCursorVisible;
        Cursor.lockState = originalCursorLockMode;

        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Debug.Log("Resume");
        isPaused = false;
    }

    void Pause()
    {
        // Store current cursor state before changing it
        originalCursorVisible = Cursor.visible;
        originalCursorLockMode = Cursor.lockState;

        // Show cursor for menu interaction
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void LoadHome()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void OpenOptions()
    {
        Debug.Log("Options button clicked - Implement options menu functionality here.");
    }

    public void ExitGame()
    {
        Debug.Log("Exit button clicked - If this were a build, the application would quit.");
        Application.Quit();
    }
}