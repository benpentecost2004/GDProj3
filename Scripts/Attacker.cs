using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{

    public float attackRange = 5f;
    public float attackCooldown = 1f;
    public int damage = 10;

    public Transform target;
    private float lastAttack;

    // Update is called once per frame
    void Update()
    {
        if(target != null && IsTargetInRange())
        {
            if (Time.time >= lastAttack + attackCooldown)
            {
                Attack();
                lastAttack = Time.time;
            }
        }
    }

    private bool IsTargetInRange()
    {
        return Vector3.Distance(transform.position, target.position) <= attackRange;
    }

    private void Attack()
    {
        Debug.Log($"{gameObject.name} is attacking {target.name}!");

        // Check if the target has a Health component to reduce health
        Health targetHealth = target.GetComponent<Health>();
        if (targetHealth != null)
        {
            targetHealth.TakeDamage(damage);
        }
    }

}
