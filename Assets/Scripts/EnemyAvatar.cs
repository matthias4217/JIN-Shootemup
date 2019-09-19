using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAvatar : BaseAvatar
{

    public delegate void DeathEvent();
    public event DeathEvent OnDeathEvent;

    private GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        _gameManager = (GameManager) GameObject.FindObjectOfType(typeof(GameManager));
        OnDeathEvent += _gameManager.EnemyIsDead;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnBecameInvisible() {
        Destroy(gameObject);
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
