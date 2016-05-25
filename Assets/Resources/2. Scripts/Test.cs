using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Test<T> : MonoBehaviour {

    public RectTransform _rTrans;
    public float startAngle, presentAngle, endAngle, chVal;
    public BlockGenerator blockG;
    
    void Awake()
    {
        //_rTrans = GetComponent<RectTransform>();
        //startAngle = 90.0f;
        //endAngle = _rTrans.eulerAngles.z;
        //chVal = -6.0f;
        blockG = BlockGenerator.Instance;
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void CallMove(int i)
    {
        StartCoroutine(this.move());
    }

    IEnumerator move()
    {
        yield return new WaitForSeconds(0.3f);
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

        //if(startAngle != endAngle)
        //{
        //    _rTrans.localRotation = new Quaternion(0, 0, startAngle, 1.0f);
        //    startAngle += chVal;

        //    yield return new WaitForSeconds(time);
        //}
        //else
        //{
        //    startAngle = 90.0f;
        //    yield return 0;
        //}
    }
}
