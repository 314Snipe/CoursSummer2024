using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieAI : MonoBehaviour
{
    public GameObject player; // Ссылка на объект игрока
    public float attackRange = 2f; // Радиус атаки
    public float attackDamage = 10f; // Урон от атаки
    public float speed = 5f; // Скорость передвижения

    private NavMeshAgent agent; // Агент навигации
    private Animator animator; // Аниматор
    private float lastAttackTime = 0f; // Время последней атаки

    void Start()
    {
        // Получаем компонент NavMeshAgent
        agent = GetComponent<NavMeshAgent>();

        // Получаем компонент Animator
        animator = GetComponent<Animator>();

        // Устанавливаем скорость движения агента
        agent.speed = speed;
    }

    void Update()
    {
        // Проверяем, находится ли игрок в радиусе атаки
        if (Vector3.Distance(transform.position, player.transform.position) <= attackRange)
        {
            // Останавливаем движение
            agent.isStopped = true;

            // Проверяем, достаточно ли времени прошло с момента последней атаки
            if (Time.time >= lastAttackTime + 1f)
            {
                // Атакуем игрока
                AttackPlayer();
                lastAttackTime = Time.time;
            }
        }
        else
        {
            // Двигаемся к игроку
            agent.isStopped = false;
            agent.SetDestination(player.transform.position);

            // Анимируем ходьбу
            animator.SetBool("IsWalking", true);
        }
    }

    // Метод для атаки игрока
    private void AttackPlayer()
    {
        // Анимируем атаку
        animator.SetTrigger("Attack");

        // Наносим урон игроку
        player.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
    }
}