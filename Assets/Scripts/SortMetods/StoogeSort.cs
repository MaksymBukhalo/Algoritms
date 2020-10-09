using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoogeSort : BaseSortClass
{
    public InstantiateAlgoritmsVisulisation InstantiateAlgoritms;

    public void StartStoogeSort()
    {
        StartCoroutine(StoogeSortMetods(InstantiateAlgoritms.Variables1));
    }

    private IEnumerator StoogeSortMetods(List<RectTransform> listForSorted)
	{
        yield return StartCoroutine(StoogeSortMetods(listForSorted, 0, listForSorted.Count - 1));
    }

    private IEnumerator StoogeSortMetods(List<RectTransform> listGorSorted, int startIndex, int endIndex)
    {
        if (listGorSorted[startIndex].rect.height > listGorSorted[endIndex].rect.height)
        {
            Swap(ref listGorSorted, startIndex, endIndex);
        }

        if (endIndex - startIndex > 1)
        {
            var len = (endIndex - startIndex + 1) / 3;
            StartCoroutine(StoogeSortMetods(listGorSorted, startIndex, endIndex - len));
            StartCoroutine(StoogeSortMetods(listGorSorted, startIndex + len, endIndex));
            StartCoroutine(StoogeSortMetods(listGorSorted, startIndex, endIndex - len));
        }
        yield break;
    }
}
