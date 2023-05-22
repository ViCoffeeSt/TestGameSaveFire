using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private GameObject _loseWindow;

    public float MaxProgress;
    public float CurrentProgress;
    public float DecreaseRate;

    public Slider ProgressBarSlider;

    void Start()
    {
        ProgressBarSlider.maxValue = MaxProgress;
        ProgressBarSlider.value = CurrentProgress;
        _loseWindow.SetActive(false);    
    }

    void Update()
    {
        CurrentProgress -= DecreaseRate * Time.deltaTime;
        ProgressBarSlider.value = CurrentProgress;

        if(CurrentProgress <= 0)
        {
            _loseWindow.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void IncreaseProgress(float amount)
    {
        CurrentProgress += amount;
        CurrentProgress = Mathf.Clamp(CurrentProgress, 0f, MaxProgress);
        ProgressBarSlider.value = CurrentProgress;
    }
}
