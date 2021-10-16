using System.Collections;
using UnityEngine;
using TMPro;
public class DialougeUI : MonoBehaviour
{
    [SerializeField] private TMP_Text TextLabel;
    [SerializeField] private DialougeObject Welcome;
    [SerializeField] private GameObject DialougeBox;
    private TypewriterEffect typewriterEffect;
    private void Start()
    {
        typewriterEffect = GetComponent<TypewriterEffect>();
       
        CloseDialougeBox();
        ShowDialouge(Welcome);
    }



 




    public void ShowDialouge(DialougeObject dialougeObject)
    {   
        DialougeBox.SetActive(true);
        StartCoroutine(StepThroughDialouge(dialougeObject));
    }
    private IEnumerator StepThroughDialouge(DialougeObject dialougeObject)
    {
        foreach (string dialouge in dialougeObject.Dialouge)
        {
            yield return typewriterEffect.Run(dialouge,TextLabel);
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));

            
        }

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space)); CloseDialougeBox();

    }

    private void CloseDialougeBox()
    {
        DialougeBox.SetActive(false);
        TextLabel.text = string.Empty;
    }



}
