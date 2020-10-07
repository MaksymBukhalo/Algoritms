using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakerSort : BaseSortClass
{
    public InstantiateAlgoritmsVisulisation instantiateAlgoritms;

    public void StartSortShaker()
    {
		StartCoroutine(ShakerSortMetods(instantiateAlgoritms.variables));
	}


    private IEnumerator ShakerSortMetods(List<RectTransform> listForSorted)
    {
        for (var i = 0; i < listForSorted.Count / 2; i++)
        {
            var swapFlag = false;
            for (var j = i; j < listForSorted.Count - i - 1; j++)
            {
                if (listForSorted[j].rect.height > listForSorted[j + 1].rect.height)
                {
                    Swap(ref listForSorted, j, j + 1);
                    swapFlag = true;
                    yield return new WaitForSeconds(0.001f);
                }
            }

            for (var j = listForSorted.Count - 2 - i; j > i; j--)
            {
                if (listForSorted[j - 1].rect.height > listForSorted[j].rect.height)
                {
                    Swap(ref listForSorted, j - 1, j);
                    swapFlag = true;
                    yield return new WaitForSeconds(0.001f);
                }
            }

            if (!swapFlag)
            {
                break;
            }
        }
    }
}
