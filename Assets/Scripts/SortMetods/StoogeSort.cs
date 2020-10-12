using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoogeSort : BaseSortClass
{
	public InstantiateAlgoritmsVisulisation InstantiateAlgoritms;

	public void StartStoogeSort()
	{
		StartCoroutine(StoogeSortMetods(InstantiateAlgoritms.Variables, 0, InstantiateAlgoritms.Variables.Count - 1));
	}

	private IEnumerator StoogeSortMetods(List<RectTransform> listGorSorted, int startIndex, int endIndex)
	{
		if (listGorSorted[startIndex].rect.height > listGorSorted[endIndex].rect.height)
		{
			Swap(ref listGorSorted, startIndex, endIndex);
		}
		yield return new WaitForSeconds(0.001f);
		if (endIndex - startIndex > 1)
		{
			var len = (endIndex - startIndex +1) / 3;
			StartCoroutine(StoogeSortMetods(listGorSorted, startIndex, endIndex - len));
			StartCoroutine(StoogeSortMetods(listGorSorted, startIndex + len, endIndex));
			StartCoroutine(StoogeSortMetods(listGorSorted, startIndex, endIndex - len));
		}
	}

	private void StoogeSortMetod(List<RectTransform> listGorSorted, int startIndex, int endIndex)
	{
		if (listGorSorted[startIndex].rect.height > listGorSorted[endIndex].rect.height)
		{
			Swap(ref listGorSorted, startIndex, endIndex);
		}

		if (endIndex - startIndex > 1)
		{
			var len = (endIndex - startIndex + 1) / 3;
			StoogeSortMetod(listGorSorted, startIndex, endIndex - len);
			StoogeSortMetod(listGorSorted, startIndex + len, endIndex);
			StoogeSortMetod(listGorSorted, startIndex, endIndex - len);
		}
	}
}
