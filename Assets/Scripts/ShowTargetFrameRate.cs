using UnityEngine;
using UnityEngine.UI;

public class ShowTargetFrameRate : MonoBehaviour
{
    public Text _mLabelFrameRate = null;
    public Button _mButtonDefault = null;
    public Button _mButtonFPS30 = null;
    public Button _mButtonFPS60 = null;
    public Button _mButtonFPS90 = null;
    public Button _mButtonFPS120 = null;
    public Button _mButtonFPS144 = null;

    // Start is called before the first frame update
    void Start()
    {
        if (_mButtonDefault)
        {
            _mButtonDefault.onClick.AddListener(() => {
                Application.targetFrameRate = -1;
                if (_mLabelFrameRate)
                {
                    _mLabelFrameRate.text = "Target Frame Rate: Default";
                }
            });
        }

        if (_mButtonFPS30)
        {
            _mButtonFPS30.onClick.AddListener(() => {
                Application.targetFrameRate = 30;
                if (_mLabelFrameRate)
                {
                    _mLabelFrameRate.text = string.Format("Target Frame Rate: {0} FPS", Application.targetFrameRate);
                }
            });
        }

        if (_mButtonFPS60)
        {
            _mButtonFPS60.onClick.AddListener(() => {
                Application.targetFrameRate = 60;
                if (_mLabelFrameRate)
                {
                    _mLabelFrameRate.text = string.Format("Target Frame Rate: {0} FPS", Application.targetFrameRate);
                }
            });
        }

        if (_mButtonFPS90)
        {
            _mButtonFPS90.onClick.AddListener(() => {
                Application.targetFrameRate = 90;
                if (_mLabelFrameRate)
                {
                    _mLabelFrameRate.text = string.Format("Target Frame Rate: {0} FPS", Application.targetFrameRate);
                }
            });
        }

        if (_mButtonFPS120)
        {
            _mButtonFPS120.onClick.AddListener(() => {
                Application.targetFrameRate = 120;
                if (_mLabelFrameRate)
                {
                    _mLabelFrameRate.text = string.Format("Target Frame Rate: {0} FPS", Application.targetFrameRate);
                }
            });
        }

        if (_mButtonFPS144)
        {
            _mButtonFPS144.onClick.AddListener(() => {
                Application.targetFrameRate = 144;
                if (_mLabelFrameRate)
                {
                    _mLabelFrameRate.text = string.Format("Target Frame Rate: {0} FPS", Application.targetFrameRate);
                }
            });
        }
    }
}
