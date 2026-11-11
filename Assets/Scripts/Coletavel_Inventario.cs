using Unity.VisualScripting;
using UnityEngine;

public class ColetavelInventario : MonoBehaviour
{
    public string nomeDoItem = "Coletável";
    public float velocidadeGiro = 90f;

    void Update()
    {
        transform.Rotate(0, velocidadeGiro * Time.deltaTime, 0);

    }
    private void OnTriggerEnter(Collider outro)
    {
        Inventario inventario = outro.GetComponent<Inventario>();
        if (inventario != null)
        {
            inventario.AdicionarItem(nomeDoItem);
            Destroy(gameObject);
        }
    }

}
