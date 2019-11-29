using Hjd.Bamboo.Prop.Data;
using UnityEngine;
using UnityEngine.UI;

public class PackageTest : MonoBehaviour
{
    [SerializeField] private Text showText;
    [SerializeField] private Button button;

    private UserPropInfo _userPropInfo;
    // Start is called before the first frame update
    void Start()
    {
        _userPropInfo = new UserPropInfo();
        _userPropInfo.wuxing = 1000;
        if (!showText)
            showText = GetComponentInChildren<Text>();
        showText.text = _userPropInfo.wuxing.ToString();
        button.onClick.AddListener(() =>
        {
            _userPropInfo.wuxing += 1;
            showText.text = _userPropInfo.wuxing.ToString();
        });
    }
}

