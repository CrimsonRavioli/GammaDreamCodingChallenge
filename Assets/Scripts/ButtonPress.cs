using UnityEngine;
using System;
using UnityEngine.Events;

public class ButtonPress : MonoBehaviour
{

 
    public ButtonEvent ButtonPressed;

    private void OnTriggerEnter (Collider other)
    {
        //activate the event when the player enters the trigger 
        if (other.tag == "Player")
        {
            ButtonPressed.Invoke(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Deactivate the event when the player leaves the trigger 
        if (other.tag == "Player")
        {
            ButtonPressed.Invoke(false);
        }
    }
}
[Serializable]
public class ButtonEvent  : UnityEvent<bool> { }
