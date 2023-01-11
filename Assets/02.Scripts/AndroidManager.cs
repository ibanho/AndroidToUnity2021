using TMPro;
using UnityEngine;

public class AndroidManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _label;

    public void AndroidToUnity(string msg)
    {
        _label.text = msg;
    }
}
