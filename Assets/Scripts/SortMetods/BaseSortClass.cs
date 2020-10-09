using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSortClass : MonoBehaviour
{
    protected void Swap(ref List<RectTransform> listForSorted, int firstValue, int secondValue)
    {
        Vector3 transform1 = listForSorted[firstValue].transform.position;
        Vector3 transform2 = listForSorted[secondValue].transform.position;
        SwapPosition(ref transform1, ref transform2);
        listForSorted[firstValue].transform.position = transform1;
        listForSorted[secondValue].transform.position = transform2;
        var temp = listForSorted[firstValue];
        listForSorted[firstValue] = listForSorted[secondValue];
        listForSorted[secondValue] = temp;
    }

	//protected void Swap(ref List<RectTransform> listForSorted, List<RectTransform> listForSorteTempArray)
	//{
 //       while
 //       Vector3 transform1 = listForSorted[firstValue].transform.position;
 //       Vector3 transform2 = listForSorted[secondValue].transform.position;
 //       SwapPosition(ref transform1, ref transform2);
 //       listForSorted[firstValue].transform.position = transform1;
 //       listForSorted[secondValue].transform.position = transform2;
 //       var temp = listForSorted[firstValue];
 //       listForSorted[firstValue] = listForSorted[secondValue];
 //       listForSorted[secondValue] = temp;
 //   }

	protected void SwapPosition(ref Vector3 transform1, ref Vector3 transform2)
    {
        var temp = transform1;
        transform1 = transform2;
        transform2 = temp;
    }
}
