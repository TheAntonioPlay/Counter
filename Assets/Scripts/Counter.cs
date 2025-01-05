using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private Coroutine _counterCoroutine;
    private float _counter = 0f;
    private float _delay = 0.5f;

    public event Action<float> Changed;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_counterCoroutine == null)
            {
                _counterCoroutine = StartCoroutine(IncreaseCounter(_delay));
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

        while (enabled)
        {
            _counter++;
            Changed?.Invoke(_counter);
            yield return wait;
        }
    }
}
