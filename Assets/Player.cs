using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public WeaponController weapon; // Ссылка на компонент WeaponController оружия

    // Метод для стрельбы
    public void Fire()
    {
        weapon.Fire(); // Вызываем метод Fire у компонента WeaponController оружия
    }

    // Метод для оснащения оружия
    public void EquipWeapon()
    {
        weapon.Equip();
    }

    // Метод для снятия оружия
    public void UnequipWeapon()
    {
        weapon.Unequip();
    }
}
