using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertionSort : BaseSortClass
{
    public InstantiateAlgoritmsVisulisation instantiateAlgoritms;

    public void StartInsertionSort()
    {
        StartCoroutine(InsertionSortMetods(instantiateAlgoritms.variables));
    }

    private IEnumerator InsertionSortMetods(List<RectTransform> listForSorted)
    {
        for (var i = 0; i < listForSorted.Count; i++)
        {
            var key = listForSorted[i];
            var j = i;
            while ((j > 0) && (listForSorted[j - 1].rect.height > key.rect.height))
            {
                Swap(ref listForSorted, j-1, j);
                j--;
                yield return new WaitForSeconds(0.001f);
            }

            listForSorted[j] = key;
        }
    }
}
