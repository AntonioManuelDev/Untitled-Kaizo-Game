using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    bool colorChanging = false;
    Color targetColor;
    Color currentColor;
    float colorChangeDuration = 1f; // Duration of color change in seconds

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeColorSmoothly());
    }

    // Coroutine to smoothly change the color
    IEnumerator ChangeColorSmoothly()
    {
        while (true)
        {
            if (!colorChanging)
            {
                targetColor = new Color(randCol(), randCol(), randCol());
                colorChanging = true;
            }

            float elapsedTime = 0f;
            currentColor = GetComponent<TextMeshProUGUI>().color; // Use TextMeshProUGUI instead of TextMeshPro

            while (elapsedTime < colorChangeDuration)
            {
                elapsedTime += Time.deltaTime;
                float t = elapsedTime / colorChangeDuration;
                GetComponent<TextMeshProUGUI>().color = Color.Lerp(currentColor, targetColor, t); // Use TextMeshProUGUI instead of TextMeshPro
                yield return null;
            }

            colorChanging = false;
            yield return null;
        }
    }

    float randCol()
    {
        return Random.Range(0f, 1f);
    }
}