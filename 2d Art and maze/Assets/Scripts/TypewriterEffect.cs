using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TypewriterEffect : MonoBehaviour
{

    [SerializeField] private float writerSpeed = 45f;
    public Coroutine Run(string TexttoType,TMP_Text textLabel)
    {
        return StartCoroutine(TypeText(TexttoType, textLabel));
    }

    private IEnumerator TypeText(string TexttoType, TMP_Text textLabel)
    {
        //following line is so writing hapend shortly after starting game
        //yield return new WaitForSeconds(1);
        float t = 0;
        int charIndex = 0;

        while(charIndex < TexttoType.Length)
        {
            t += Time.deltaTime *writerSpeed;
            charIndex = Mathf.FloorToInt(t);
            charIndex = Mathf.Clamp(charIndex, 0, TexttoType.Length);

            textLabel.text = TexttoType.Substring(0, charIndex);

            yield return null;

        }
        textLabel.text = TexttoType;
    }

  
}
