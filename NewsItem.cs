using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewsItem : MonoBehaviour
{
    public Text title;
    public Text text;
    public Text link;

    public void OpenLink()
    {
        Application.OpenURL(link.text);
    }
}
