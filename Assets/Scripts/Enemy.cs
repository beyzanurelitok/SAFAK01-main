using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Collider coll;
    float speed = 2f;
    private GameObject Player;
    public int HP, damage;
    public bool range;
    public bool isenemy;
    public player player;
    void Start()
    {
        HP = 3;
        damage = 1;

        Player = GameObject.FindGameObjectWithTag("Player");
        player = GameObject.FindObjectOfType<player>();
        
        coll = GetComponent<Collider>();

    }
    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;


    }
    public int GetCurrentHP()
    {
        return HP;
    }
    void Update()
    {
        if (HP > 0 && Player != null && Player.activeSelf)
        {
            float distance = Vector3.Distance(transform.position, Player.transform.position);

            if (distance < 25f)
            {
                transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
            }

            
        }


    }
    public void applyDamage()
    {
        player.hp -= damage;
        print("damgade0");
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {

            applyDamage();
        }

    }

}
