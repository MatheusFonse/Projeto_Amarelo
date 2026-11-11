using UnityEngine;

public class InimigoPerseguicao : MonoBehaviour
{
    public Transform jogador;
    public float velocidade = 3.5f;
    public float distanciaDeAtaque = 1.5f;


    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        if (jogador == null) return;


        Vector3 direcao = jogador.position - transform.position;
        direcao.y = 0;


        float distancia = direcao.magnitude;


        if (distancia > distanciaDeAtaque)
        {
            direcao.Normalize();


            Quaternion rotacao = Quaternion.LookRotation(direcao);

            rotacao *= Quaternion.Euler(0, 90, 0);

            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                rotacao,
                Time.fixedDeltaTime * 5f
            );


            rb.MovePosition(
                rb.position + direcao * velocidade * Time.fixedDeltaTime
            );
        }
    }
}