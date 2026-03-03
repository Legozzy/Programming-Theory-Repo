using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private TextMeshProUGUI combatLogText;
    [SerializeField] private int maxMessages = 3;

    private List<string> messages = new List<string>();

    private void Awake()
    {
        Instance = this;
    }

    public void ShowMessage(string message)
    {
        messages.Add(message);

        if(messages.Count > maxMessages)
        {
            messages.RemoveAt(0);
        }

        combatLogText.text = string.Join("\n", messages);
    }
}
