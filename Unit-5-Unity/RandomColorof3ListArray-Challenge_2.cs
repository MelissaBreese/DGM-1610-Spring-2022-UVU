using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RandomColorof3ListArray : MonoBehaviour
{
    // Start is called before the first frame update

    public UnityEvent triggerEnterEvent;
    Renderer objectRenderer;
    public void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }

    public void randomColorRange()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
        objectRenderer.material.color = newColor;
    }


    private void RandomColor()
    {
        Color[] colors = {
    Color.blue,
    Color.red,
    Color.green};
        List<Color> usedColors = new();

        for (int i = 0; i <= colors.Length; i++)
        {
            bool foundNewColor = false;
            while (!foundNewColor)
            {
                int rand = Random.Range(0, colors.Length);
                if (!usedColors.Contains(colors[rand]))
                    foundNewColor = true;
            }
        }
    }
}