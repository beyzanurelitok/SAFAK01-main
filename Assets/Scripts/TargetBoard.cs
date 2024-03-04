using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBoard : MonoBehaviour
{
    private int hitCount = 0;

    // Bu metot, bullet (ate�lenen mermi) TopPoint adl� bir gameobject'e �arpt���nda �a�r�l�r.
    public void OnBulletHit()
    {
        // Hedefi yok et
        Destroy(gameObject);

        // Hedef vuruldu�unda hitCount'i art�r
        hitCount++;

        // Consola ka� tane hedef vuruldu�unu yazd�r
        Debug.Log("Vurulan Hedef Say�s�: " + hitCount);
    }
}
