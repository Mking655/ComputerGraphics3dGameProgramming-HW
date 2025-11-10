using UnityEngine;
using UnityEngine.InputSystem;

public class Pause : MonoBehaviour
{
    public bool isPaused = false;
    public GameObject unpausedStuff;
    public GameObject pausedStuff;
    private void Start()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            unpausedStuff.SetActive(true);
            pausedStuff.SetActive(false);
            isPaused = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Time.timeScale = 0;
            unpausedStuff.SetActive(false);
            pausedStuff.SetActive(true);
            isPaused = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void unPause()
    {
        Time.timeScale = 1;
        unpausedStuff.SetActive(true);
        pausedStuff.SetActive(false);
        isPaused = false;
        Cursor.lockState = CursorLockMode.None;
    }
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            if (isPaused)
            {
                Time.timeScale = 1;
                unpausedStuff.SetActive(true);
                pausedStuff.SetActive(false);
                isPaused = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                Time.timeScale = 0;
                unpausedStuff.SetActive(false);
                pausedStuff.SetActive(true);
                isPaused = true;
                Cursor.lockState = CursorLockMode.None;
            }
           
        }
    }
}
