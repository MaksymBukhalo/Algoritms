using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateAlgoritmsVisulisation : MonoBehaviour
{
	public int ArraySize = 100;
	public GameObject ExampleVariable;
	public RectTransform PanelViewContent;
	public List<RectTransform> Variables;
	public Text nameAlgoritms;
	private RectTransform _exampleVeriableRectTransform;

	private void Start()
	{
		Variables = new List<RectTransform>(ArraySize);
		SetVariables();
	}

	public void SetVariables()
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
