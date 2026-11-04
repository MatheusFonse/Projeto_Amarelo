using UnityEngine;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using TMPro;
using Unity.VisualScripting;

public class Inventario : MonoBehaviour
{
    public List<string> itens = new List<string>();
    [Header ("Interface(UI)")]
    public GameObject painelInventario;
    public TextMeshProUGUI textoItem;


    void Start()
    {
       painelInventario.SetActive(false);
        AtualizarTela();

    }


    void Update()
    {
        if (Keyboard.current.iKey.wasPressedThisFrame)
        {
            painelInventario.SetActive(!painelInventario.activeSelf);
        }
    }
    public void AdicionarItem(string nomeDoItem)
    {
        itens.Add(nomeDoItem);
        Debug.Log("Guardou no inventário: " + nomeDoItem);
        AtualizarTela();
    }
    void AtualizarTela()
    {
       if (itens.Count == 0)
        {
            textoItem.text = "Inventário vazio";
        }
        else
        {
            textoItem.text = "";
            foreach (string item in itens)
            {
                textoItem.text += item + "\n";
            }
        }
    }
}
