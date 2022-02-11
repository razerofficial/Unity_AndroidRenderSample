using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTargetFrameRate : MonoBehaviour
{
    public Text _mLabelFrameRate = null;
    public Button _mButtonUncapped = null;
    public Button _mButtonFPS30 = null;
    public Button _mButtonFPS60 = null;
    public Button _mButtonFPS90 = null;

    // Start is called before the first frame update
    void Start()
    {
        if (_mButtonUncapped)
        {
            _mButtonUncapped.onClick.AddListener(() => {
                Application.targetFrameRate = -1;
                if (_mLabelFrameRate)
                {
                    _mLabelFrameRate.text = "Target Frame Rate:  Uncapped";
                }
            });
        }

        if (_mButtonFPS30)
        {
            _mButtonFPS30.onClick.AddListener(() => {
                Application.targetFrameRate = 30;
                if (_mLabelFrameRate)
                {
                    _mLabelFrameRate.text = string.Format("Target Frame Rate:  {0} FPS", Application.targetFrameRate);
                }
            });
        }

        if (_mButtonFPS60)
        {
            _mButtonFPS60.onClick.AddListener(() => {
                Application.targetFrameRate = 60;
                if (_mLabelFrameRate)
                {
                    _mLabelFrameRate.text = string.Format("Target Frame Rate:  {0} FPS", Application.targetFrameRate);
                }
            });
        }

        if (_mButtonFPS90)
        {
            _mButtonFPS90.onClick.AddListener(() => {
                Application.targetFrameRate = 90;
                if (_mLabelFrameRate)
                {
                    _mLabelFrameRate.text = string.Format("Target Frame Rate:  {0} FPS", Application.targetFrameRate);
                }
            });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
