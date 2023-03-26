using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class staminaBar : MonoBehaviour
{
    public Slider slider;

    public void setMaxStamina(float stamina)
    {
        slider.maxValue = stamina;
        slider.value = stamina;
    }
    public void setStamina(float stamina)
    {
        slider.value = stamina;
    }
}
