using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class QiuckSort : BaseSortClass
{
	public InstantiateAlgoritmsVisulisation InstantiateAlgoritms;

	public void StartQuickSort()
	{
		List<RectTransform> listForSorted = InstantiateAlgoritms.Variables;
		StartCoroutine(QuickSort(listForSorted, 0, listForSorted.Count - 1));
	}

	private IEnumerator QuickSort(List<RectTransform> listForSorted, int minIndex, int maxIndex)
	{
		if (minIndex >= maxIndex)
		{
			yield break;
		}

		int pivot = minIndex - 1;
		for (int i = minIndex; i < maxIndex; i++)
		{
			if (listForSorted[i].rect.height < listForSorted[maxIndex].rect.height)
			{
				pivot++;
				Swap(ref listForSorted, pivot, i);
				yield return new WaitForSeconds(0.001f);
			}
		}
		pivot++;
		Swap(ref listForSorted, pivot, maxIndex);
		yield return new WaitForSeconds(0.001f);
		StartCoroutine(QuickSort(listForSorted, minIndex, pivot - 1));
		StartCoroutine(QuickSort(listForSorted, pivot + 1, maxIndex));

		yield break;
	}

	private int Partition(List<RectTransform> listForSorteds, int minIndex, int maxIndex)
	{
		int pivot = minIndex - 1;
		for (int i = minIndex; i < maxIndex; i++)
		{
			if (listForSorteds[i].rect.height < listForSorteds[maxIndex].rect.height)
			{
				pivot++;
				Swap(ref listForSorteds, pivot, i);
			}
		}

		
		pivot++;
		Swap(ref listForSorteds, pivot, maxIndex);
		return pivot;
	}
}
