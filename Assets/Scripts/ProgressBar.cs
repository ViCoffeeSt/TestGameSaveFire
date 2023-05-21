using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public float MaxProgress;
    public float CurrentProgress;
    public float DecreaseRate;

    public Slider ProgressBarSlider;

    void Start()
    {
        ProgressBarSlider.maxValue = MaxProgress;
        ProgressBarSlider.value = CurrentProgress;
    }

    void Update()
    {
        CurrentProgress -= DecreaseRate * Time.deltaTime;
        ProgressBarSlider.value = CurrentProgress;

        if(CurrentProgress <= 0)
        {
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
