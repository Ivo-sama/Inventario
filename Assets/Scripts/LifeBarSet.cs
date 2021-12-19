using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBarSet : MonoBehaviour
{
    [Space]
    [Header("Controles da Barrinha de Vida")]
    [Space]
    [Tooltip("Conforme a vida reduz em porcentagem, a barrinha de vida regride.")]
    public float vida = 100;
    public Image Barra;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Barra.fillAmount = vida/100;
    }
}
