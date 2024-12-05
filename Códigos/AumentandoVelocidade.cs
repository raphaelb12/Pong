using UnityEngine;

public class AumentandoVelocidade : MonoBehaviour
{
    public float ritmo;

    // Método chamado automaticamente quando ocorre uma colisão
    private void OnCollisionEnter2D(Collision2D colisao)
    {
            // Obtém o componente Bola do objeto colidido
            Bola ball = colisao.gameObject.GetComponent<Bola>();
            if (ball != null) // Verifica se a bola foi encontrada
            {
                // Obtém a normal do ponto de contato
                Vector2 normal = colisao.GetContact(0).normal;

                // Chama a função MaisForca para aplicar uma força extra
                ball.AddForce(-normal * this.ritmo);
            }
        }
    }