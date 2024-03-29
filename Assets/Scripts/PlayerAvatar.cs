﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvatar : BaseAvatar
{
    private float energy;
    public float Energy {
        get {
            return this.energy;
        }
        set {
            this.energy = value;
        }
    }
    
    [SerializeField]
    private float maxEnergy;
    public float MaxEnergy {
        get {
            return this.maxEnergy;
        }
        set {
            this.maxEnergy = value;
        }
    }
    
    [SerializeField]
    private float energyCooldown;
    public float EnergyCooldown {
        get {
            return this.energyCooldown;
        }
        set {
            this.energyCooldown = value;
        }
    }

    public delegate void DeathEvent();
    public event DeathEvent OnDeathEvent;

    // Start is called before the first frame update
    void Start()
    {
        Energy = MaxEnergy;
        OnDeathEvent += GameManager.PlayerIsDead;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void TakeDamage(float damage) {
        Health -= damage;
        if (Health < 0) {
            Die();
        }
    }

    public override void Die() {
        if (OnDeathEvent != null) {
            OnDeathEvent();
        }
        Destroy(gameObject);
    }

}
