using UnityEngine;

public class ShowTextOnTrigger : MonoBehaviour
{
    [Header("Перетащи сюда надпись Text (TMP) из иерархии")]
    public GameObject textObject;

    void Start()
    {
        // Скрываем текст в начале игры
        if (textObject != null)
        {
            textObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, что зашел игрок
        if (other.CompareTag("Player"))
        {
            if (textObject != null)
            {
                textObject.SetActive(true); // Включаем текст
                Destroy(gameObject); // Удаляем сам триггер-куб
            }
        }
    }
}
