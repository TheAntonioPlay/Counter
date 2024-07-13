using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    private Coroutine _counterCoroutine;
    private int counter = 0;

    private void Update()
    {
        float delay = 0.5f;

        if (Input.GetMouseButtonDown(0))
        {
            if (_counterCoroutine == null)
            {
                _counterCoroutine = StartCoroutine(IncreaseCounter(delay));
            }
            else
            {
                StopCoroutine(_counterCoroutine);
                _counterCoroutine = null;
            }
        }
    }

    private IEnumerator IncreaseCounter(float delay)
    {
        var wait = new WaitForSeconds(delay);

        while (true)
        {
            DisplayCounter(counter++);
            yield return wait;
        }
    }

    private void DisplayCounter(int count)
    {
        _text.text = count.ToString("");
    }
}
