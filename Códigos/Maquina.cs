using UnityEngine;

public class Maquina : Barra
{
    public Rigidbody2D Bola; // Corrigido o nome do tipo Rigidbody2D
    
    private void FixedUpdate()
    {
        // Se a bola está se movendo para a direita
        if (Bola.velocity.x > 0.0f)
        {
            // Se a bola está acima da posição da máquina
            if (Bola.position.y > transform.position.y)
            {
                rb.AddForce(Vector2.up * velocidade); // Move para cima
            }
        }
        // Se a bola está abaixo da posição da máquina
        else if (Bola.position.y < transform.position.y)
        {
            rb.AddForce(Vector2.down * velocidade); // Move para baixo
        }
        else
        {
            // Se a máquina está acima da linha central
            if (transform.position.y > 0.0f)
            {
                rb.AddForce(Vector2.down * velocidade); // Move para baixo
            }
            // Se a máquina está abaixo da linha central
            else if (transform.position.y < 0.0f)
            {
                rb.AddForce(Vector2.up * velocidade); // Move para cima
            }
        }
    }
}