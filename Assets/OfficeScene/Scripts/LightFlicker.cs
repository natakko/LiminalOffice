using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public Light lightSource;       // Ссылка на источник света
    public float minIntensity = 0.5f; // Минимальная яркость
    public float maxIntensity = 1.5f; // Максимальная яркость
    public float flickerSpeed = 0.1f; // Скорость мерцания

    void Update()
    {
        if (lightSource != null)
        {
            // Случайно меняем яркость в заданном диапазоне
            lightSource.intensity = Random.Range(minIntensity, maxIntensity);
        }
    }
}
