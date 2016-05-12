/////////////////////////////////
// UIText.cs			       //
/////////////////////////////////
//  2016.04.07  오명훈 created //
/////////////////////////////////
// UI의 Text의 조정 스크립트의 //
// 기본 스크립트입니다.        //
/////////////////////////////////
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class UIText : MonoBehaviour {

	[SerializeField] protected Text _text;

	protected virtual void Awake()
	{
		_text = GetComponent<Text>();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public virtual void CallCoroutine(int takeN)
	{
		StartCoroutine(Change(takeN));
	}

	protected virtual IEnumerator Change(int takeN)
	{
		yield return null;
	}
}
