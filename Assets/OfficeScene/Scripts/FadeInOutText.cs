using UnityEngine;
using TMPro;
using System.Collections;

public class FadeInOutText : MonoBehaviour
{
    public float fadeInDuration = 2f;  // Время появления
    public float stayDuration = 3f;    // Время видимости
    public float fadeOutDuration = 2f; // Время исчезновения

    private TextMeshPro tmpText;

    void OnEnable()
    {
        tmpText = GetComponent<TextMeshPro>();
        if (tmpText != null)
        {
            // Устанавливаем прозрачность в ноль
            Color c = tmpText.color;
            c.a = 0;
            tmpText.color = c;
            StartCoroutine(FadeProcess());
        }
    }

    IEnumerator FadeProcess()
    {
        // Появление
        yield return StartCoroutine(FadeTo(1f, fadeInDuration));
        // Ожидание
        yield return new WaitForSeconds(stayDuration);
        // Исчезновение
        yield return StartCoroutine(FadeTo(0f, fadeOutDuration));
        // Удаление
        Destroy(gameObject);
    }

    IEnumerator FadeTo(float targetAlpha, float duration)
    {
        float currentTime = 0;
        Color startColor = tmpText.color;

        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            float alpha = Mathf.Lerp(startColor.a, targetAlpha, currentTime / duration);
            tmpText.color = new Color(startColor.r, startColor.g, startColor.b, alpha);
            yield return null;
        }
    }
}
