using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthHealth : MonoBehaviour
{
    public float health = 100f;

    public void TakeDamage(float amount)
    {
        health -= amount;

        // Проверка, жив ли зомби
        if (health <= 0)
        {
            // Уничтожаем зомби
            Destroy(gameObject);
        }
    }
}
