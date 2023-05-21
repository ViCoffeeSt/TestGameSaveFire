using UnityEngine;

public class ProgressBarTrigger : MonoBehaviour
{
    public float ProgressIncreaseAmount;
    public float WaterAmount;

    private int _fire;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fire"))
        {
            ProgressBar progressBar = FindObjectOfType<ProgressBar>();
            if (progressBar != null)
            {
                progressBar.IncreaseProgress(ProgressIncreaseAmount);
            }

            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Fire"))
        {
            _fire++;
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Water"))
        {
            ProgressBar progressBar = FindObjectOfType<ProgressBar>();

            progressBar.IncreaseProgress(-WaterAmount);

            Destroy(other.gameObject);
        }
    }
}
