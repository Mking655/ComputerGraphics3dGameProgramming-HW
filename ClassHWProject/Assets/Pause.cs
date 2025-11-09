using UnityEngine;
using UnityEngine.InputSystem;

public class Pause : MonoBehaviour
{
    GameObject unpausedStuff;
    GameObject pausedStuff;
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Time.timeScale = 0;
            unpausedStuff.SetActive(false);
            pausedStuff.SetActive(true);
        }
    }
}
