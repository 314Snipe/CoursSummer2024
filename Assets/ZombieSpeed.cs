using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpeed : MonoBehaviour
{
// Цель к которой будем двигаться
public Transform target;

// Скорость персонажа в секунду
public float speed;

void Update()
{
    // Размер шага равен скорость * время кадра.
    float step = speed * Time.deltaTime;

    // Переместите нашу позицию на шаг ближе к цели.
    transform.position = Vector3.MoveTowards(transform.position, target.position, step);
}
}
