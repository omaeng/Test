/////////////////////////////////
// UIRotate.cs			       //
/////////////////////////////////
//  2016.04.07  오명훈 created //
/////////////////////////////////
// UI의 기울기를 변경하는	   //
// 스크립트입니다.		       //
/////////////////////////////////
using UnityEngine;
using System.Collections;

public class UIRotate : UIMove {

	[SerializeField] private float startAngle, presentAngle, endAngle, chVal, time;

    protected override void Awake()
    {
        base.Awake();
        startAngle = 90.0f;
        endAngle = _rTrans.eulerAngles.z;
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
        presentAngle = startAngle;
        while (presentAngle != endAngle)
        {
            if (presentAngle < endAngle)
            {
                presentAngle = endAngle;
                _rTrans.eulerAngles = new Vector3(0, 0, presentAngle);
                break;
            }
            _rTrans.eulerAngles = new Vector3(0, 0, presentAngle);
            presentAngle += chVal;
            yield return null;
        }

        yield return null;

    }

    public override void ClickInit()
    {
        _rTrans.eulerAngles = new Vector3(0, 0, startAngle);
    }
}
