using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public AudioSource audioSource;
    private bool hasPlayed = false;

    public void PlayDoorSound()
    {
        if (!hasPlayed)
        {
            // Эта строчка меняет тон (Pitch)
            audioSource.pitch = Random.Range(0.9f, 1.1f);
            audioSource.Play();

            hasPlayed = true;

            // Удаляет дверь через 2 секунды, чтобы звук дозвучал
            Destroy(gameObject, 2f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayDoorSound();
        }
    }
}
