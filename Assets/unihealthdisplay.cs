using TMPro;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    //Referencja do textu
    //Referencja do playerhealth
    public TextMeshProUGUI healthText;
    public playerhealth playerhealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerhealth.OnHealthChanged += OnHealthChanged;
    }

    public void OnHealthChanged(float newHealth, float ammountChanged)
    {
        //Debug.Log("On Health Changed Event");
    }

    //Kiedy event zostanie wywo³any
    //Zmieniæ napis
}
