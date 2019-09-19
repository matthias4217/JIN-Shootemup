using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    [SerializeField]
    private Slider slider;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Player" + gameManager.Player.name);
        if (gameManager.Player != null) {
            Debug.Log("Max Health" + gameManager.Player.MaxHealth);
            slider.maxValue = gameManager.Player.MaxHealth;
            slider.value = gameManager.Player.Health;
            // maxvalue
        }
    }
}
