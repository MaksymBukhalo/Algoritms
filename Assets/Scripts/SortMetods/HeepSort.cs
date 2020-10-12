using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeepSort : BaseSortClass
{
	public InstantiateAlgoritmsVisulisation InstantiateAlgoritms;

	public void StartHeapSort()
	{
		List<RectTransform> listForSorted = InstantiateAlgoritms.Variables;
		StartCoroutine(HeapSort(listForSorted));
	}

	private IEnumerator HeapSort(List<RectTransform> ListForSorted)
	{
		int n = ListForSorted.Count;
		for (int i = n / 2 - 1; i >= 0; i--)
		{
			Heapify(ListForSorted, n, i);
		}
		for (int i = n - 1; i >= 0; i--)
		{
			Swap(ref ListForSorted, 0, i);
			yield return new WaitForSeconds(0.001f);
			Heapify(ListForSorted, i, 0);
		}
	}
	private void Heapify(List<RectTransform> ListForSorted, int n, int i)
	{
		int largest = i;
		int left = 2 * i + 1;
		int right = 2 * i + 2;
		if (left < n && ListForSorted[left].rect.height > ListForSorted[largest].rect.height)
		{
			largest = left;
		}
		if (right < n && ListForSorted[right].rect.height > ListForSorted[largest].rect.height)
		{
			largest = right;
		}
		if (largest != i)
		{
			//Swap(ref ListForSorted, i, largest);
			StartCoroutine(HeapifyWait(ListForSorted, i, largest));
			Heapify(ListForSorted, n, largest);
		}
	}

	private IEnumerator HeapifyWait(List<RectTransform> ListForSorted, int n, int i)
	{
		Swap(ref ListForSorted, n, i);
		yield return new WaitForSeconds(0.001f);
	}
}
