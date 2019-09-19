using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    [SerializeField]
    private Slider healthSlider;

    [SerializeField]
    private Slider energySlider;

    
    [SerializeField]
    private Text scoreValue;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreValue.text = gameManager.Score.ToString();
        if (gameManager.Player != null) {
            healthSlider.maxValue = gameManager.Player.MaxHealth;
            healthSlider.value = gameManager.Player.Health;
            energySlider.maxValue = gameManager.Player.MaxEnergy;
            energySlider.value = gameManager.Player.Energy;
        }
    }
}
