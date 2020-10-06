using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateAlgoritmsVisulisation : MonoBehaviour
{
	public GameObject ExampleVariable;
	public RectTransform PanelViewContent;
	public int ArraySize = 100;

	private RectTransform exampleVeriableRectTransform;
	private List<GameObject> variables;

	private void Start()
	{
		exampleVeriableRectTransform = ExampleVariable.GetComponent<RectTransform>();
	}

	public void SetVariables()
	{
		Transform startPosition = ExampleVariable.transform;
		float whidth = PanelViewContent.sizeDelta.x / ArraySize;
		float Height = (PanelViewContent.sizeDelta.y / 100) * (Random.Range(0, 1000) / PanelViewContent.sizeDelta.y);
		variables = new List<GameObject>(100);
		for(int i = 0;i<variables.Count-1;i++)
		{
			
		}
	}

	private RectTransform SetRectTransformNewVarieble(float width, float height)
	{
		RectTransform rectTransform = 
	}
}
