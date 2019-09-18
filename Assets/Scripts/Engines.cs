using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engines : MonoBehaviour
{
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
        private set {
            this.position = value;
        }
    }

    private BaseAvatar _baseAvatar;


    // Start is called before the first frame update
    void Start()
    {
        _baseAvatar = GetComponent<BaseAvatar>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Position = transform.position;
        Position = Position + _baseAvatar.MaxSpeed * Time.deltaTime * Speed;
        transform.position = Position;
    }
}
