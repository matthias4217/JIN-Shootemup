using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGun : MonoBehaviour
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
    private float cooldown;
    public float Cooldown {
        get {
            return this.cooldown;
        }
        set {
            this.cooldown = value;
        }
    }

    private Engines _playerEngine;
    [SerializeField]
    private SimpleBullet bullet;

    private float timeSinceLastShot;

    // Start is called before the first frame update
    void Start()
    {
        _playerEngine = GetComponent<Engines>();
        timeSinceLastShot = 0; 
    }

    public void Fire() {
        if (timeSinceLastShot >= Cooldown) {
            SimpleBullet clonedBullet = Instantiate(bullet, transform);
            clonedBullet.Init(damage, speed, _playerEngine.Position + new Vector2(1, 0));
            timeSinceLastShot = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastShot += Time.deltaTime;
    }
}
