using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeSort : BaseSortClass
{
	public InstantiateAlgoritmsVisulisation InstantiateAlgoritms;
	private Vector3 startPosition;

	public void StartMergeSort()
	{
		MergeSortMetod(InstantiateAlgoritms.Variables1);
	}



	private List<RectTransform> MergeSortMetod(List<RectTransform> listForSorted)
	{
		startPosition = listForSorted[0].transform.position;
		return MergeSortMetod(listForSorted, 0, listForSorted.Count - 1);
	}

	private List<RectTransform> MergeSortMetod(List<RectTransform> listForSorted, int lowIndex, int highIndex)
	{
		if (lowIndex < highIndex)
		{
			var middleIndex = (lowIndex + highIndex) / 2;
			MergeSortMetod(listForSorted, lowIndex, middleIndex);
			MergeSortMetod(listForSorted, middleIndex + 1, highIndex);
			Merge(listForSorted, lowIndex, middleIndex, highIndex);
		}
		return listForSorted;
	}

	private void Merge(List<RectTransform> listForSorted, int lowIndex, int middleIndex, int highIndex)
	{
		var left = lowIndex;
		var right = middleIndex + 1;
		var listForSorteTempArray = new List<RectTransform>(highIndex - lowIndex + 1);

		while ((left <= middleIndex) && (right <= highIndex))
		{
			if (listForSorted[left].rect.height < listForSorted[right].rect.height)
			{
				listForSorteTempArray.Add(listForSorted[left]);
				left++;
			}
			else
			{
				listForSorteTempArray.Add(listForSorted[right]);
				right++;
			}
		}

		for (var i = left; i <= middleIndex; i++)
		{
			listForSorteTempArray.Add(listForSorted[i]);
		}

		for (var i = right; i <= highIndex; i++)
		{
			listForSorteTempArray.Add(listForSorted[i]);
		}
		for (var i = 0; i < listForSorteTempArray.Count; i++)
		{
			listForSorted[lowIndex + i] = listForSorteTempArray[i];
		}
		StartCoroutine(Wui(listForSorted));
	}

	private IEnumerator Wui(List<RectTransform> listForSorted)
	{
		Vector3 position = startPosition;
		listForSorted[0].transform.position = position;
		int j = 1;
		while (j < listForSorted.Count && startPosition != null)
		{
			listForSorted[j].transform.position = new Vector3(position.x + listForSorted[j].rect.width, position.y, position.z);
			position = listForSorted[j].transform.position;
			j++;
			yield return new WaitForSeconds(0.001f);
		}
		position = startPosition;
	}
}

