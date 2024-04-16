using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SacarMenu : MonoBehaviour
{
    public Animator animatorAActivar;
    public string NombreTrigger;

    // Método que se ejecuta cuando se presiona el botón
    public void PresionarBoton()
    {
        // Verificar que el Animator esté asignado
        if (animatorAActivar != null)
        {
            // Activar la animación
            animatorAActivar.SetTrigger(NombreTrigger);
        }
        else
        {
            Debug.LogWarning("No se ha asignado el Animator para activar la animación.");
        }
    }

}
