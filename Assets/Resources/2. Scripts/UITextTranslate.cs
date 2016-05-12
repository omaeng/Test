/////////////////////////////////
// UITextTranslate.cs		   //
/////////////////////////////////
//  2016.04.07  오명훈 created //
/////////////////////////////////
// UI의 Text의 위치를 변경하는 //
// 스크립트입니다.		       //
/////////////////////////////////
using UnityEngine;
using System.Collections;

public class UITextTranslate : UIText {

	[SerializeField] private float startPosition, presentPosition, endPosition, chVal, time;
	[SerializeField] private RectTransform _rTrans;

	protected override void Awake ()
	{
		base.Awake ();
        _rTrans = GetComponent<RectTransform>();
		endPosition = _rTrans.localPosition.x;

	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void CallCoroutine (int takeN)
	{
		StartCoroutine(Move());
	}

	private IEnumerator Move()
    {
        yield return new WaitForSeconds(time);
        presentPosition = startPosition;
        while (presentPosition>=endPosition)
		{
            _rTrans.localPosition = new Vector3(presentPosition, _rTrans.localPosition.y, _rTrans.localPosition.z);
            presentPosition += chVal;
			yield return null;
		}
	}

    public void ClickInit()
    {
        _rTrans.localPosition = new Vector3(startPosition, _rTrans.localPosition.y, _rTrans.localPosition.z);
    }
}
