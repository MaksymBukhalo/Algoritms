using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReinstalArray : MonoBehaviour
{
	public InstantiateAlgoritmsVisulisation Visulisation;
	public GameObject ExampleVariable;
	public Transform Content;
	public GameObject PrefabExampleVariable;
	private Vector3 _startPosition;

	private void Awake()
	{
		_startPosition = ExampleVariable.transform.position;
	}

	public void StartReinstalArray()
	{
		ClearList();
		GameObject newVeribles = Instantiate(PrefabExampleVariable,Content);
		newVeribles.transform.position = _startPosition;
		Visulisation.ExampleVariable1 = newVeribles;
		//Visulisation.SetVariables();
	}

	private void ClearList()
	{
		//int i = 0;
		//while(i< Visulisation.Variables1.Count)
		//{
		//	Destroy(Visulisation.Variables[i].gameObject);
		//	i++;
		//}
		//Visulisation.Variables.Clear();
	}
}
