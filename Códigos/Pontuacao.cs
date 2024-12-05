using UnityEngine;
using UnityEngine.EventSystems;

public class Pontuacao : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public EventTrigger.TriggerEvent ativaPontuacao;
    private void OnCollisionEnter2D(Collision2D colisao)
    {
            // Obtém o componente Bola do objeto colidido
            Bola ball = colisao.gameObject.GetComponent<Bola>();
            if (ball != null) // Verifica se a bola foi encontrada
            {
                BaseEventData eventData = new BaseEventData(EventSystem.current);
                this.ativaPontuacao.Invoke(eventData);
        }
}

}