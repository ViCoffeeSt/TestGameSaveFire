using UnityEngine;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private GameObject PlayLevelButton;

    void Start()
    {
        Time.timeScale = 0f;
        PlayLevelButton.SetActive(true);
    }

    public void PlayLevel()
    {
        Time.timeScale = 1f;
        PlayLevelButton.SetActive(false);
    }
}
