using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SacarMenu : MonoBehaviour
{
    public Animator animatorAActivar;
    public string NombreTrigger;

    // M�todo que se ejecuta cuando se presiona el bot�n
    public void PresionarBoton()
    {
        // Verificar que el Animator est� asignado
        if (animatorAActivar != null)
        {
            // Activar la animaci�n
            animatorAActivar.SetTrigger(NombreTrigger);
        }
        else
        {
            Debug.LogWarning("No se ha asignado el Animator para activar la animaci�n.");
        }
    }

}
