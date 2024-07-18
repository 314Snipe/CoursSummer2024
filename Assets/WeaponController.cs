using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WeaponController : MonoBehaviour
{
    public GameObject bulletPrefab; // Префаб пули
    public Transform bulletSpawnPoint; // Точка, из которой стреляет пуля
    public float fireRate = 0.5f; // Скорострельность
    private float nextFireTime = 0f; // Следующее время выстрела

    private bool isEquipped = false; // Флаг, показывающий, что оружие в руке

    // Метод для оснащения оружия
    public void Equip()
    {
        isEquipped = true;
    }

    // Метод для снятия оружия
    public void Unequip()
    {
        isEquipped = false;
    }

    // Метод для стрельбы
    public void Fire()
    {
        // Проверка, оснащено ли оружие
        if (isEquipped && Time.time >= nextFireTime)
        {
            nextFireTime = Time.time + 1f / fireRate;
            Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        }
    }
}