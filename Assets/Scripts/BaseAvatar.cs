using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseAvatar : MonoBehaviour
{
    [SerializeField]
    private float maxSpeed;
    public float MaxSpeed {
        get {
            return this.maxSpeed;
        }
        private set {
            this.maxSpeed = value;
        }
    }
    
    [SerializeField]
    private float health;
    public float Health {
        get {
            return this.health;
        }
        set {
            this.health = value;
        }
    }
    
    [SerializeField]
    private float maxHealth;
    public float MaxHealth {
        get {
            return this.maxHealth;
        }
        private set {
            this.maxHealth = value;
        }
    }

    public abstract void TakeDamage(float damage);
    public abstract void Die();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
