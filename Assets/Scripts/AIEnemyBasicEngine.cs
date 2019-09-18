using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemyBasicEngine : MonoBehaviour
{
    private Engines _engine;
    // Start is called before the first frame update
    void Start()
    {
        _engine = GetComponent<Engines>();
    }

    // Update is called once per frame
    void Update()
    {
        _engine.Speed = new Vector2(-1,0);
    }
}
