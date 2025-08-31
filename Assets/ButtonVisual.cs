using UnityEngine;

public class ButtonVisual : MonoBehaviour
{
    [SerializeField] GameObject _button;
    [SerializeField] Color buttonUpColor = Color.gray;
    [SerializeField] Color buttonDownColor = Color.red;
    MeshRenderer _buttonRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _buttonRenderer = _button.GetComponent<MeshRenderer>();
        _buttonRenderer.material.color = buttonUpColor;
    }

    public void SetButtonDown(bool isDown)
    {
        if (isDown)
        {
            _buttonRenderer.material.color = buttonDownColor;
            _button.transform.localPosition = new Vector3(0, 0.1f, 0);
        }
        else
        {
            _buttonRenderer.material.color = buttonUpColor;
            _button.transform.localPosition = new Vector3(0, .5f, 0);
        }
        
    }
}
