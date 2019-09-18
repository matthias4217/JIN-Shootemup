using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum BulletType {
    PlayerBullet,
    EnemyBullet,
};


public abstract class Bullet : MonoBehaviour
{
    
    [SerializeField]
    private float damage;
    public float Damage {
        get {
            return this.damage;
        }
        set {
            this.damage = value;
        }
    }
    
    [SerializeField]
    private Vector2 speed;
    public Vector2 Speed {
        get {
            return this.speed;
        }
        set {
            this.speed = value;
        }
    }
    
    [SerializeField]
    private Vector2 position;
    public Vector2 Position {
        get {
            return this.position;
        }
        set {
            this.position = value;
        }
    }

    public abstract void Init(float damage, Vector2 speed, Vector2 position);
    public abstract void UpdatePosition();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnBecameInvisible() {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collider) {
        Debug.Log("Prout");
        collider.gameObject.GetComponent<BaseAvatar>().TakeDamage(Damage);
        Destroy(gameObject);
    }
}
