using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class QiuckSort : BaseSortClass
{
	public InstantiateAlgoritmsVisulisation InstantiateAlgoritms;

	public void StartQuickSort()
	{
		List<RectTransform> listForSorted = InstantiateAlgoritms.Variables1;
		StartCoroutine(QuickSort(listForSorted, 0, listForSorted.Count - 1));
	}

	private IEnumerator QuickSort(List<RectTransform> listForSorted, int minIndex, int maxIndex)
	{
		if (minIndex >= maxIndex)
		{
			yield break;
		}

		var pivotIndex = Partition(listForSorted, minIndex, maxIndex);
		yield return new WaitForSeconds(0.1f);
		StartCoroutine(QuickSort(listForSorted, minIndex, pivotIndex - 1));
		StartCoroutine(QuickSort(listForSorted, pivotIndex + 1, maxIndex));

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
