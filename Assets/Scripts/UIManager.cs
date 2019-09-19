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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.Player != null) {
            Debug.Log("Health " + gameManager.Player.Health + "/" + gameManager.Player.MaxHealth);
            healthSlider.maxValue = gameManager.Player.MaxHealth;
            healthSlider.value = gameManager.Player.Health;
            energySlider.maxValue = gameManager.Player.MaxEnergy;
            energySlider.value = gameManager.Player.Energy;
        }
    }
}
