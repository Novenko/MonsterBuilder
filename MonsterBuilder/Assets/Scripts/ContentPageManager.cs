using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContentPageManager : MonoBehaviour
{
    public List<GameObject> pages = new List<GameObject>();

    int currentPageID = 0;

    void Update()
    {
        
    }

    public void ChangePageNext()
    {
        pages[currentPageID].SetActive(false);
        currentPageID++;
        if (currentPageID >= pages.Count)
        {
            currentPageID = 0;
        }

        pages[currentPageID].SetActive(true);
    }

    public void ChangePagePrev()
    {
        pages[currentPageID].SetActive(false);
        currentPageID--;
        if (currentPageID < 0)
        {
            currentPageID = pages.Count;
        }

        pages[currentPageID].SetActive(true);
    }
}
