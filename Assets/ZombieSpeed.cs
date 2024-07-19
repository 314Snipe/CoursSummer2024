using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpeed : MonoBehaviour
{
    public GameObject player; // Ссылка на объект игрока
    public float speed = 5f; // Скорость движения
    public float rotationSpeed = 5f; // Скорость поворота

    private Rigidbody rb; // Компонент Rigidbody

    void Start()
    {
        // Получаем компонент Rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Проверяем, найден ли объект игрока
        if (player != null)
        {
            // Получаем вектор направления движения к игроку
            Vector3 direction = player.transform.position - transform.position;

            // Нормализуем вектор направления
            direction.Normalize();

            // Перемещаем зомби в направлении игрока
            rb.velocity = direction * speed;
        }
    }
}