using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100f;

    public void TakeDamage(float amount)
    {
        health -= amount;

        // Проверка, жив ли игрок
        if (health <= 0)
        {
            // Уничтожаем игрока
            Destroy(gameObject);
        }
    }
}
