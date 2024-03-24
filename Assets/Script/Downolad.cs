using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Downolad : MonoBehaviour
{
    private int presentDownolad = 1;
    [SerializeField] private Slider downoladSlider;
    [SerializeField] private TextMeshProUGUI percentText;

    void Start()
    {
        downoladSlider.value = presentDownolad;
        percentText.text = $"{presentDownolad} %";
    }

    public void ChangePercentDownolad()
    {
        presentDownolad = (int)downoladSlider.value;
        percentText.text = $"{presentDownolad} %";
    }
}
