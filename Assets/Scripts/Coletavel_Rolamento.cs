using Unity.VisualScripting;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public string nomeDoItem = "Coletável";
    public float velocidadeGiro = 90f;

    void Update()
    {
        transform.Rotate(0, velocidadeGiro * Time.deltaTime, 0);

    }

}
