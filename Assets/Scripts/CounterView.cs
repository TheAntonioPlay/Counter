using System.Collections;
using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _counterText;
    [SerializeField] private Counter _counter;

    private void OnEnable()
    {
        _counter.Changed += DisplayCounter;
    }

    private void OnDisable()
    {
        _counter.Changed -= DisplayCounter;
    }

    private void DisplayCounter(float count)
    {
        _counterText.text = count.ToString("");
    }
}
