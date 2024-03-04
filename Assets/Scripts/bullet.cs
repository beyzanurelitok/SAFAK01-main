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
            enemy.TakeDamage(damageAmount); // Düþmandan HP azalt

            if (enemy.GetCurrentHP() <= 0) // Düþmanýn HP'si 0'a eþit veya daha az ise
            {
                Destroy(other.gameObject); // Düþmaný yok et
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        // Çarpýþan nesnenin TopPoint adýnda bir gameobject olup olmadýðýný kontrol et
        if (collision.gameObject.CompareTag("TopPoint"))
        {
            // Eðer çarpýlan nesne bir TopPoint ise, onun üstündeki Hedef gameobjectini bul
            Transform Target = collision.transform.parent;


            // Hedefi yok et
            Destroy(Target.gameObject);

            // Mermiyi yok et
            Destroy(gameObject);

            destroyedCount++;
            Debug.Log("Toplam Yok Edilen Hedef Sayýsý: " + destroyedCount);
        }
    }
}
