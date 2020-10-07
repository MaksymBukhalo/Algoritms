using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeSort : BaseSortClass
{
	public InstantiateAlgoritmsVisulisation instantiateAlgoritms;


    public void StartMergeSort()
    {
        //RectTransform[] listForSorted = new RectTransform[50];
        //listForSorted.CopyTo(instantiateAlgoritms.variables,0);
        //StartCoroutine(MergeSortMetod());
    }



    private IEnumerator MergeSortMetod(RectTransform[] listForSorted)
    {
        return MergeSortMetod(listForSorted, 0, listForSorted.Length - 1);
    }

    private IEnumerator MergeSortMetod(RectTransform[] listForSorted, int lowIndex, int highIndex)
    {
        if (lowIndex < highIndex)
        {
            var middleIndex = (lowIndex + highIndex) / 2;
            MergeSortMetod(listForSorted, lowIndex, middleIndex);
            MergeSortMetod(listForSorted, middleIndex + 1, highIndex);
            Merge(listForSorted, lowIndex, middleIndex, highIndex);
            yield return new WaitForSeconds(0.001f);
        }
    }

    static void Merge(RectTransform [] listForSorted, int lowIndex, int middleIndex, int highIndex)
    {
        var left = lowIndex;
        var right = middleIndex + 1;
        var gameObjectsTempArray = new List<RectTransform>(highIndex - lowIndex + 1);
        var index = 0;

        while ((left <= middleIndex) && (right <= highIndex))
        {
            if (listForSorted[left].rect.height < listForSorted[right].rect.height)
            {
                gameObjectsTempArray[index] = listForSorted[left];
                left++;
            }
            else
            {
                gameObjectsTempArray[index] = listForSorted[right];
                right++;
            }

            index++;
        }

        for (var i = left; i <= middleIndex; i++)
        {
            gameObjectsTempArray[index] = listForSorted[i];
            index++;
        }

        for (var i = right; i <= highIndex; i++)
        {
            gameObjectsTempArray[index] = listForSorted[i];
            index++;
        }

        for (var i = 0; i < gameObjectsTempArray.Count; i++)
        {
            listForSorted[lowIndex + i] = gameObjectsTempArray[i];
        }
    }
}
