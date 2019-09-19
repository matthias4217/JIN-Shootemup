using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Bullet : MonoBehaviour
{
        
    public enum BulletType {
        PlayerBullet,
        EnemyBullet,
    };

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

    [SerializeField]
    private BulletType type;
    public BulletType Type {
        get {
            return this.type;
        }
        private set {
            this.type = value;
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
        EnemyAvatar enemyAvatar = collider.gameObject.GetComponent<EnemyAvatar>();
        PlayerAvatar playerAvatar = collider.gameObject.GetComponent<PlayerAvatar>();

        if (type == BulletType.PlayerBullet && enemyAvatar != null) {
            enemyAvatar.TakeDamage(Damage);
            Destroy(gameObject);
            Debug.Log("Enemy hit");
        }
        else if (type == BulletType.EnemyBullet && playerAvatar != null) {
            playerAvatar.TakeDamage(Damage);
            Destroy(gameObject);
            Debug.Log("Player hit");
        }
    }
}
