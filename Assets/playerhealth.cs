using System;
using System.Collections;
using UnityEngine;

public class playerhealth : MonoBehaviour
{
    public float Maxhealth = 100;
    private float Health;
    private bool CanReceiveDamage = true;
    public float InvincibilityTime = 2;

    public delegate void HealthChangedHandler(float health);
    public event HealthChangedHandler OnHealthChanged;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Health = Maxhealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddDamage(float damage)
    {
        if (CanReceiveDamage)
        {
            Health -= damage;
            OnHealthChanged?.Invoke(Health, damage);
            CanReceiveDamage = false;
            StartCoroutine(InvincibilityTimer(InvincibilityTime, ResetInvincibility));

            Debug.Log(Health);
        }
    }
    IEnumerator InvincibilityTimer(float time, Action callback)
    {
        yield return new WaitForSeconds(time);
        callback.Invoke();
    }
    private void ResetInvincibility()
    {
        CanReceiveDamage = true;
        Debug.Log(Health);
    }
    public void AddHealth(float heal)
    {
        Health += heal;
        OnHealthChanged?.Invoke(Health, heal);
        Debug.Log(Health);

    }
}
