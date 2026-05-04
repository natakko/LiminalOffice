using UnityEngine;

public class PlayOnce : MonoBehaviour
{
    [Header("Настройки задержки")]
    [Tooltip("Через сколько секунд включится радио")]
    public float delay = 2.0f;

    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();

        if (audio != null && audio.clip != null)
        {
            // Запускаем воспроизведение с задержкой
            audio.PlayDelayed(delay);

            // Удаляем объект из памяти только после того, как он доиграет
            // Время удаления = задержка + длительность самого файла
            Destroy(gameObject, delay + audio.clip.length);
        }
    }
}
