using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public int hp;
    public bool live;
    GameObject[] enemies;
    public GameObject bulletPrefab;
    public GameObject weapon;
    private bool gameStarted = true;
    void Start()
    {
        hp = 5;
        live = true;
        enemies = GameObject.FindGameObjectsWithTag("enemy");
    }

    // Update is called once per frame
    void Update()
    {

        // Her güncelleme adýmýnda playerHealth deðerini kontrol edelim
        if (hp <= 0)
        {
            // Eðer playerHealth 0 veya daha azsa, game over sahnesine yönlendir
            SceneManager.LoadScene("GameOver");
        }

        if (gameStarted)
        {
            HandleShootingInput();
        }
    }
    
    void UseWeapon()
    {
        Transform bulletSpawnPoint = weapon.transform.Find("BulletSpawnPoint");

        if (bulletSpawnPoint != null)
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();

            if (bulletRb != null)
            {
                bulletRb.AddForce(bulletSpawnPoint.forward * 2000f);
            }

            bullet.AddComponent<bullet>();
        }
        else
        {
            Debug.LogError("BulletSpawnPoint not found!");
        }
    }
    void HandleShootingInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UseWeapon();

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bayrak"))
        {
            SceneManager.LoadScene("Congarts");
        }
    }
}
