/////////////////////////////////
// UITranslate.cs		       //
/////////////////////////////////
//  2016.04.07  오명훈 created //
/////////////////////////////////
// UI의 위치를 변경하는		   //
// 스크립트입니다.		       //
/////////////////////////////////
using UnityEngine;
using System.Collections;

public class UITranslate : UIMove {

	[SerializeField] private float startPosition, presentPosition, endPosition, chVal, time;

    protected override void Awake()
    {
        base.Awake();
		endPosition = _rTrans.localPosition.y;
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    protected override IEnumerator Move()
    {
        yield return new WaitForSeconds(time);
        presentPosition = startPosition;
        while (presentPosition >= endPosition)
        {
            _rTrans.localPosition = new Vector3(_rTrans.localPosition.x, presentPosition, _rTrans.localPosition.z);
            presentPosition += chVal;
            yield return null;
        }
    }

    public override void ClickInit()
    {
        _rTrans.localPosition = new Vector3(_rTrans.localPosition.x, startPosition, _rTrans.localPosition.z);
    }
}
