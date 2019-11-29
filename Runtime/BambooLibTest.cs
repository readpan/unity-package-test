using Hjd.Bamboo.Prop.Data;
using UnityEngine;

namespace System
{
    public class BambooLibTest : MonoBehaviour
    {
        private UnityEngine.UI.Text _text;

        private UserPropInfo _userPropInfo;

        private void Start()
        {
            _userPropInfo = new UserPropInfo();
            _userPropInfo.nickName = "成功";
            _text = GetComponentInChildren<UnityEngine.UI.Text>();
            _text.text = _userPropInfo.nickName;
        }
    }
}