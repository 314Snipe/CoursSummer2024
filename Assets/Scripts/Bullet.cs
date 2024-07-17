using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f; // Скорость пули
    public float damage = 20f; // Урон пули

    // Метод, вызываемый при столкновении с другим объектом
    private void OnTriggerEnter(Collider other)
    {
        // Проверка, является ли объект зомби
        if (other.gameObject.CompareTag("Zombie"))
        {
            // Получаем скрипт здоровья зомби
            ZombieHealth zombieHealth = other.gameObject.GetComponent<ZombieHealth>();

            // Если скрипт найден, наносим урон зомби
            if (zombieHealth != null)
            {
                zombieHealth.TakeDamage(damage);
            }

            // Уничтожаем пулю
            Destroy(gameObject);
        }
    }

    // Метод для движения пули
    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}

