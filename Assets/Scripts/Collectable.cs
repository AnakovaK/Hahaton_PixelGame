using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Класс реализует предметы, которые можно подобрать в инвентарь
/// </summary>
[RequireComponent(typeof(Item))]
public class Collectable : MonoBehaviour
{
    /// <summary>
    /// Этот метод передаёт информацию о коллизии с игроком.
    /// </summary>
    /// <param name="collision">Параметр коллайдера предмета, с чем сталкивается предмет</param>
    /// <returns></returns>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();
        
        if(player)
        {
            Item item = GetComponent<Item>();

            if(item != null)
            {
                player.inventory.Add(item);
                //Debug.Log(Inventory.Slot.activeItems);
                if (Inventory.activeItems <= 4)
                {
                    Destroy(this.gameObject);
                }
                
            }
        }
    }
}

