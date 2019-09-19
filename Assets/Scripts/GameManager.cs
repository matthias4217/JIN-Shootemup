using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private PlayerAvatar playerPrefab;

    [SerializeField]
    private EnemyAvatar enemyPrefab;

    [SerializeField]
    private float enemySpawnInterval;
    public float EnemySpawnInterval {
        get {
            return this.enemySpawnInterval;
        }
        private set {
            this.enemySpawnInterval = value;
        }
    }

    private int score;
    public int Score {
        get {
            return this.score;
        }
        private set {
            this.score = value;
        }
    }

    private float lastEnemySpawn;

    private PlayerAvatar player;
    public PlayerAvatar Player {
        get {
            return this.player;
        }
        private set {
            this.player = value;
        }
    }

    float worldHeight;
    float heightOrigin;

    // Start is called before the first frame update
    void Start()
    {
        // Instantiate Player
        Player = Instantiate(playerPrefab);
        lastEnemySpawn = 0;
        worldHeight = 10;
        heightOrigin = 5;
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // every so often, instantiate enemy at random height
        lastEnemySpawn += Time.deltaTime;
        if (lastEnemySpawn > EnemySpawnInterval) {
            float height = Random.Range(heightOrigin - worldHeight, heightOrigin);
            Instantiate(enemyPrefab, new Vector2(6.6f, height), Quaternion.identity);
            lastEnemySpawn = 0;
        }
    }

    public static void PlayerIsDead() {
        Debug.Log("The Player is dead !");
        SceneManager.LoadScene("Menu");
    }

    
    public void EnemyIsDead() {
        Debug.Log("An enemy is dead !");
        Score += 100;
    }
}
