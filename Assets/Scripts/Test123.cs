using System.Collections;
using TMPro;
using UnityEngine;

public class Test123 : MonoBehaviour
{
    private int counter = 0;
    private Coroutine counterCoroutine;

    void Update()
    {
        // Check if the left mouse button was clicked
        if (Input.GetMouseButtonDown(0))
        {
            if (counterCoroutine == null)
            {
                // Start the coroutine if it is not already running
                counterCoroutine = StartCoroutine(IncreaseCounter());
            }
            else
            {
                // Stop the coroutine if it is already running
                StopCoroutine(counterCoroutine);
                counterCoroutine = null;
            }
        }
    }

    private IEnumerator IncreaseCounter()
    {
        while (true)
        {
            // Increase the counter
            counter++;
            // Log the current value of the counter
            Debug.Log("Counter value: " + counter);
            // Wait for 0.5 seconds
            yield return new WaitForSeconds(0.5f);
        }
    }
}
