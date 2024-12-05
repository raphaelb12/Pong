using UnityEngine;

public class Jogador : Barra
{
    // Recebe input do jogador
    private Vector2 direcao; // direção que o jogador deseja ir

    private void Update() // função que é chamada a cada frame
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            direcao = Vector2.up; // recebe o comando para direcionar para cima
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            direcao = Vector2.down; // recebe o comando para direcionar para baixo
        }
        else
        {
            direcao = Vector2.zero; // não se move
        }
    }

    private void FixedUpdate() // função chamada em intervalos de tempo fixos
    {
        if (direcao.sqrMagnitude != 0) // se a direção for diferente de zero
        {
            rb.velocity = direcao * velocidade; // move o jogador
        }
        else
        {
            rb.velocity = Vector2.zero; // para o jogador
        }
    }
}