using UnityEngine;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using TMPro;

public class Inventario : MonoBehaviour
{
    public static Inventario instancia;

    public List<string> itens = new List<string>();

    [Header("Interface (UI)")]
    public GameObject painelInventario;
    public TextMeshProUGUI textoItem;

    void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        painelInventario.SetActive(false);
        AtualizarTela();
    }

    void Update()
    {
        if (Keyboard.current != null &&
            Keyboard.current.iKey.wasPressedThisFrame)
        {
            painelInventario.SetActive(
                !painelInventario.activeSelf);
        }
    }

    public void AdicionarItem(string nomeDoItem)
    {
        itens.Add(nomeDoItem);


        AtualizarTela();
    }

    public void RemoverItem(string nomeDoItem)
    {
        if (itens.Contains(nomeDoItem))
        {
            itens.Remove(nomeDoItem);


            AtualizarTela();
        }
    }

    public bool TemItem(string nomeDoItem)
    {
        return itens.Contains(nomeDoItem);
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