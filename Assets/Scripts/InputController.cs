using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    private Engines _engine;
    private BulletGun _bulletGun;

    // Start is called before the first frame update
    void Start()
    {
        _engine = GetComponent<Engines>();
        _bulletGun = GetComponent<BulletGun>();
    }

    // Update is called once per frame
    void Update()
    {
        // update speed of engine

        float speedX = 0;
        if (Input.GetAxis("Horizontal") > 0) {
            speedX = 1;
        }
        else if (Input.GetAxis("Horizontal") < 0) {
            speedX = -1;
        }

        
        float speedY = 0;
        if (Input.GetAxis("Vertical") > 0) {
            speedY = 1;
        }
        else if (Input.GetAxis("Vertical") < 0) {
            speedY = -1;
        }
        _engine.Speed = new Vector2(speedX, speedY).normalized;
        if (Input.GetAxis("Fire1") > 0) {
            _bulletGun.Fire();
        }
    }
}
