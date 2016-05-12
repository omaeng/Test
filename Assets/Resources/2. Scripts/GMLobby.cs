/////////////////////////////////////////////
// GMLobby.cs			                   //
/////////////////////////////////////////////
//  2016.04.07  오명훈 created             //
//  2016.04.12  오명훈 버튼관련 함수 추가  //
/////////////////////////////////////////////
// Lobby를 관리 및 조정하는	               //
// 스크립트입니다.		                   //
/////////////////////////////////////////////
using UnityEngine;
using System.Collections;

public class GMLobby : MonoBehaviour {

    [SerializeField] private UIRotate[] _rotate = new UIRotate[3];
    [SerializeField] private UITranslate[] _translate = new UITranslate[3];
    [SerializeField] private UITextTranslate _textTrans = new UITextTranslate();
    [SerializeField] private UIImageColorChange[] _color = new UIImageColorChange[5];
    [SerializeField] private UIImageChange _image = new UIImageChange();
    [SerializeField] private UITextChange _text = new UITextChange();
    [SerializeField] private GameObject[] _pop = new GameObject[2];

    void Awake()
    {

    }
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void ButtonClick(int takeN)
    {
        StartCoroutine(this.Receiver(takeN));
    }

    private IEnumerator Receiver(int takeN)
    {
        // 버튼 클릭하면 이미지들의 위치를 시작값으로 변경합니다.
        for (int count = 0; count < _rotate.Length; count++)
            _rotate[count].ClickInit();
        for (int count = 0; count < _translate.Length; count++)
            _translate[count].ClickInit();
        _textTrans.ClickInit();
        // 클릭한 버튼에 따라 이미지의 색을 변경합니다.
        for (int count = 0; count < _color.Length; count++)
            _color[count].CallCoroutine(takeN);
        // 클릭한 버튼에 따라 텍스트의 내용을 변경합니다.
        _text.CallCoroutine(takeN);
        // 클릭한 버튼에 따라 이미지의 스프라이트를 변경합니다.
        _image.CallCoroutine(takeN);
        // 이미지들과 텍스트 등을 상황에 맞게 변경하도록 함수를 불러줍니다.
        for (int count = 0; count < _rotate.Length; count++)
            _rotate[count].CallCoroutine();
        for (int count = 0; count < _translate.Length; count++)
            _translate[count].CallCoroutine();
        _textTrans.CallCoroutine(takeN);
        //PopButtonCtr(takeN);
        PopActive(takeN);
        for (int count = 0; count < _pop.Length; count++)
            if(_pop[count].activeInHierarchy)
                _pop[count].SendMessage("CallFunc", takeN);
        yield return null;
    }

    private void PopActive(int takeN)
    {
        for (int count = 0; count < _pop.Length; count++)
        {
            if (!_pop[count].activeInHierarchy && takeN % 2 == 1)
                _pop[count].SetActive(true);
            //else if (_pop[count].activeInHierarchy && takeN % 2 == 0)
            //    _pop[count].SetActive(false);
            //else
            //    _pop[count].SetActive(false);
        }
    }

    // popup 메뉴창을 불러오는 버튼을 조종하는 함수입니다.
    private void PopButtonCtr(int takeN)
    {
        switch (takeN % 2)
        {
            case 1:
                PopButtonActive(true, "Show");
                if (takeN == 1)
                {
                    PopButtonTxtChange(0);
                }
                else
                {
                    PopButtonTxtChange(1);
                }
                break;
            default:
                PopButtonActive(true, "Hide");
                break;
        }
    }

    private void PopButtonTxtChange(int takeN)
    {
        for(int count = 0; count<_pop.Length;count++)
        {
            _pop[count].GetComponentInChildren<UITextChange>().CallCoroutine(takeN);
        }
    }

    private void PopButtonActive(bool visible, string trigger)
    {
        for (int count = 0; count < _pop.Length; count++)
        {
            _pop[count].SetActive(visible);
            _pop[count].GetComponent<Animator>().SetBool(trigger, true);
        }
    }
}
