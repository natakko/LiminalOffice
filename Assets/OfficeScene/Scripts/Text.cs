using UnityEngine;
using TMPro; // Важно для работы с TextMeshPro
using System.Collections;

public partial class TimedDisappear : MonoBehaviour
{
    public float waitBeforeFade = 3f; // Сколько стоит перед началом исчезновения
    public float fadeDuration = 2f;   // Как долго будет исчезать

    private TextMeshPro tmpText;

    void Start()
    {
        tmpText = GetComponent<TextMeshPro>();
        StartCoroutine(FadeOutRoutine());
    }

    IEnumerator FadeOutRoutine()
    {
        yield return new WaitForSeconds(waitBeforeFade);

        float currentTime = 0;
        Color startColor = tmpText.color;

        while (currentTime < fadeDuration)
        {
            currentTime += Time.deltaTime;
            // Плавно меняем прозрачность (Alpha)
            float alpha = Mathf.Lerp(1f, 0f, currentTime / fadeDuration);
            tmpText.color = new Color(startColor.r, startColor.g, startColor.b, alpha);
            yield return null;
        }

        Destroy(gameObject);
    }
}
