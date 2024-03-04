using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public int damageAmount = 50;
    private static int destroyedCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damageAmount); // D��mandan HP azalt

            if (enemy.GetCurrentHP() <= 0) // D��man�n HP'si 0'a e�it veya daha az ise
            {
                Destroy(other.gameObject); // D��man� yok et
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        // �arp��an nesnenin TopPoint ad�nda bir gameobject olup olmad���n� kontrol et
        if (collision.gameObject.CompareTag("TopPoint"))
        {
            // E�er �arp�lan nesne bir TopPoint ise, onun �st�ndeki Hedef gameobjectini bul
            Transform Target = collision.transform.parent;


            // Hedefi yok et
            Destroy(Target.gameObject);

            // Mermiyi yok et
            Destroy(gameObject);

            destroyedCount++;
            Debug.Log("Toplam Yok Edilen Hedef Say�s�: " + destroyedCount);
        }
    }
}
