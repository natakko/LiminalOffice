using UnityEngine;

public class WallLock : MonoBehaviour
{
    public Collider wallCollider;

    private void OnTriggerEnter(Collider other)
    {
        // Теперь скрипт сработает ТОЛЬКО если вошел объект с тегом Player
        if (other.CompareTag("Player"))
        {
            if (wallCollider != null)
            {
                wallCollider.isTrigger = false;
                Debug.Log("Путь назад отрезан игроком!");
                Destroy(gameObject);
            }
        }
    }
}
