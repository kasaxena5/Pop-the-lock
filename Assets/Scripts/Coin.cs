using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private static Vector3 initialScale = new Vector3(0, 0, 0);
    private static Vector3 finalScale = new Vector3(0.6f, 0.6f, 0.6f);

    private static Coroutine fadeIn;
    private static Coroutine fadeOut;

    private void Awake()
    {
        float randAngle = Random.Range(0, 360);
        transform.position = new Vector3(0, 2.5f, 0);
        transform.localScale = initialScale;
        transform.RotateAround(GameManager.pivotPoint, GameManager.rotationAxis, randAngle);
        fadeIn = StartCoroutine(FadeIn(GameManager.coinSpawnTime));
    }


    public void Disappear()
    {
        fadeOut = StartCoroutine(FadeOut(GameManager.coinSpawnTime));
    }

    IEnumerator FadeIn(float lerpDuration)
    {
        if (fadeIn != null)
        {
            yield return fadeIn;
        }
        if (fadeOut != null)
        {
            yield return fadeOut;
        }

        lerpDuration = lerpDuration * Time.deltaTime;
        float timeElapsed = 0;
        while (timeElapsed < lerpDuration)
        {
            float t = timeElapsed / lerpDuration;
            transform.localScale = Vector3.Lerp(initialScale, finalScale, t);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        transform.localScale = finalScale;
    }

    IEnumerator FadeOut(float lerpDuration)
    {
        if (fadeIn != null)
        {
            yield return fadeIn;
        }
        if (fadeOut != null)
        {
            yield return fadeOut;
        }

        lerpDuration = lerpDuration * Time.deltaTime;
        float timeElapsed = 0;
        while (timeElapsed < lerpDuration)
        {
            float t = timeElapsed / lerpDuration;
            transform.localScale = Vector3.Lerp(finalScale, initialScale, t);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        transform.localScale = initialScale;
        Destroy(this.gameObject);
    }
}
