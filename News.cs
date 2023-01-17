using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class News : MonoBehaviour
{
    public string[] Lines;
    public string[] FinalNews;

    public GameObject NewsItem;

    void Start()
    {
        StartCoroutine(ReadPage("https://budgames.net/News.txt"));
    }

    IEnumerator ReadPage(string Url)
    {
        WWW page = new WWW(Url);
        yield return page;

        Lines = page.text.Split('\n');

        for (int i = 0; i < Lines.Length; i++)
        {
            FinalNews = Lines[i].Split('*');

            print(FinalNews[0]);
            print(FinalNews[1]);
            print(FinalNews[2]);

            GameObject N = Instantiate(NewsItem , Vector3.zero , Quaternion.identity , GameObject.Find("Content").transform);
            N.GetComponent<NewsItem>().title.text = FinalNews[0];
            N.GetComponent<NewsItem>().text.text = FinalNews[1];
            N.GetComponent<NewsItem>().link.text = FinalNews[2];
        }
    }

}
