using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvatar : BaseAvatar
{
    // Start is called before the first frame update
    void Start()
    {
        
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
        Destroy(gameObject);
    }
}
