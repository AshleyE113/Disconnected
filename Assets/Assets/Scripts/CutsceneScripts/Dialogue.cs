using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public Text textComponent;
    public string[] lines;
    public float textSpeed;
    public int index;
    public Font OriginalFont;
    //public Text TeamText = Gameobject.Find("DialogueBox").GetComponent<Text>();

    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
        //textComponent.GetComponent<textComponent>().font = OriginalFont;
    }

    void Update()
    {
        /*
        for (index = 0; index < lines.Length; index++)
        {
            if ((lines[index].Contains("A1")) || (lines[index].Contains("A2")) || (lines[index].Contains("A3")))
            {
                //RectTransform TeamText = lines[index].GetComponent<RectTransform>();
                //TeamText.anchoredPosition = new Vector2(-91.1, 0);
             //   textComponent.GetComponent<Text>().font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
               // lines[index].x = -91.1;
                //lines[index].y = 0;

            }else
            {

                //RectTransform TeamText = lines[index].GetComponent<RectTransform>();
                //TeamText.anchoredPosition = new Vector2(-91.1, 0);
                //   textComponent.GetComponent<Text>().font = Resources.GetBuiltinResource(typeof(Font), "ethnocentric.ttf");
                //lines[index].x = 292.9365;
                //lines[index].y = 311;
            }
        }
        */
        if (Input.GetKeyDown("space"))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }

    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

}
