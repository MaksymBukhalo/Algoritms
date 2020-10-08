using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : BaseSortClass
{
	public InstantiateAlgoritmsVisulisation InstantiateAlgoritms;


    public void StartSortBubles()
	{
        StartCoroutine(BubbleSortMetods(InstantiateAlgoritms.Variables));
	}

    private IEnumerator BubbleSortMetods(List<RectTransform> listForSorted)
    {
        int len = listForSorted.Count;
        for (int i = 1; i < len; i++)
        {
            for (int j = 0; j < len - i; j++)
            {
                if (listForSorted[j].rect.height > listForSorted[j + 1].rect.height)
                {
                    Swap(ref listForSorted, j, j + 1);
                    yield return new WaitForSeconds(0.05f);
                }
            }
        }
    }
}
