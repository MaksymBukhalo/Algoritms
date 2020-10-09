using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateAlgoritmsVisulisation : MonoBehaviour
{
	public int ArraySize = 100;
	public GameObject ExampleVariable1;
	public RectTransform PanelViewContent1;
	public List<RectTransform> Variables1;
	private RectTransform _exampleVeriableRectTransform1;
	public GameObject ExampleVariable2;
	public RectTransform PanelViewContent2;
	public List<RectTransform> Variables2;
	private RectTransform _exampleVeriableRectTransform2;

	private void Start()
	{
		Variables1 = new List<RectTransform>(ArraySize);
		Variables2 = new List<RectTransform>(ArraySize);
		SetVariables(ExampleVariable1, PanelViewContent1, Variables1, _exampleVeriableRectTransform1);
		SetVariables(ExampleVariable2, PanelViewContent2, Variables2, _exampleVeriableRectTransform2);
	}

	public void SetVariables(GameObject ExampleVariable, RectTransform PanelViewContent, List<RectTransform> Variables, RectTransform _exampleVeriableRectTransform)
	{
		_exampleVeriableRectTransform = ExampleVariable.GetComponent<RectTransform>();
		Transform startPosition = ExampleVariable.transform;
		float whidth = PanelViewContent.rect.width / ArraySize;
		float random = Random.Range(0, 1000);
		float Height = (PanelViewContent.rect.height / 10f) * (random / PanelViewContent.rect.height);
		_exampleVeriableRectTransform.sizeDelta = new Vector2(whidth, Height);
		Variables.Add(_exampleVeriableRectTransform);
		int i = 1;
		while(i<ArraySize)
		{
			random = Random.Range(0, 1000);
			Height = (PanelViewContent.rect.height / 10f) * (random / PanelViewContent.rect.height);
			GameObject gameObject = Instantiate(ExampleVariable, PanelViewContent);
			gameObject.transform.position = new Vector3(startPosition.position.x + whidth, startPosition.position.y, startPosition.position.z);
			gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(whidth, Height); 
			startPosition = gameObject.transform;
			Variables.Add(gameObject.GetComponent<RectTransform>());
			i++;
		}
	}
}
