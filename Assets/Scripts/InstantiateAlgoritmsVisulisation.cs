using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateAlgoritmsVisulisation : MonoBehaviour
{
	public GameObject ExampleVariable;
	public RectTransform PanelViewContent;
	public int ArraySize = 100;

	private RectTransform exampleVeriableRectTransform;
	public List<RectTransform> variables;

	private void Start()
	{
		exampleVeriableRectTransform = ExampleVariable.GetComponent<RectTransform>();
		variables = new List<RectTransform>(ArraySize);
		SetVariables();
	}

	public void SetVariables()
	{
		Transform startPosition = ExampleVariable.transform;
		float whidth = PanelViewContent.rect.width / ArraySize;
		float random = Random.Range(0, 1000);
		float Height = (PanelViewContent.rect.height / 10f) * (random / PanelViewContent.rect.height);
		exampleVeriableRectTransform.sizeDelta = new Vector2(whidth, Height);
		variables.Add(exampleVeriableRectTransform);
		int i = 1;
		while(i<ArraySize)
		{
			random = Random.Range(0, 1000);
			Height = (PanelViewContent.rect.height / 10f) * (random / PanelViewContent.rect.height);
			GameObject gameObject = Instantiate(ExampleVariable, PanelViewContent);
			gameObject.transform.position = new Vector3(startPosition.position.x + whidth, startPosition.position.y, startPosition.position.z);
			gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(whidth, Height); 
			startPosition = gameObject.transform;
			variables.Add(gameObject.GetComponent<RectTransform>());
			i++;
		}
	}
}
