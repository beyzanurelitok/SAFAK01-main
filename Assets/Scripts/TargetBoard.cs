using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBoard : MonoBehaviour
{
    private int hitCount = 0;

    // Bu metot, bullet (ateþlenen mermi) TopPoint adlý bir gameobject'e çarptýðýnda çaðrýlýr.
    public void OnBulletHit()
    {
        // Hedefi yok et
        Destroy(gameObject);

        // Hedef vurulduðunda hitCount'i artýr
        hitCount++;

        // Consola kaç tane hedef vurulduðunu yazdýr
        Debug.Log("Vurulan Hedef Sayýsý: " + hitCount);
    }
}
