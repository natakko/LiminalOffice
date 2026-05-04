using UnityEngine;

public class CreepyPitch : MonoBehaviour
{
    private AudioSource audioSource;

    [Header("Настройки жути")]
    public float speed = 5.0f;  // Скорость, с которой голос уходит вниз
    public float amount = 0.3f; // Насколько сильно голос становится низким

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (audioSource != null)
        {
            // Формула заставляет звук только падать вниз и возвращаться в норму
            float wobble = Mathf.Abs(Mathf.Sin(Time.time * speed)) * amount;
            audioSource.pitch = 1.0f - wobble;
        }
    }
}
