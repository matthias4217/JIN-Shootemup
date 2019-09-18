using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBullet : Bullet
{
    public override void Init(float damage, Vector2 speed, Vector2 position)
    {
        this.Damage = damage;
        this.Speed = speed;
        this.Position = position;
    }

    public override void UpdatePosition()
    {
        Position = Position + Time.deltaTime * Speed;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePosition();
        transform.position = Position;
    }
}
