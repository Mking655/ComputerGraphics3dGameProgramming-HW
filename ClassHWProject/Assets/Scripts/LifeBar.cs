using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    public Image image;
    public Life targetLife;

    void Update()
    {   
        image.fillAmount = targetLife.amount / 100;
    }
}
