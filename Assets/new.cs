using UnityEngine;
using UnityEngine.UI;

public class TapCounter : MonoBehaviour
{
    public Text tapCountText;
    public Button tapButton;

    private int totalTaps = 1;

    void Start()
    {
        if (tapCountText == null)
        {
            Debug.LogError("tapCountText is not assigned!");
        }

        if (tapButton == null)
        {
            Debug.LogError("tapButton is not assigned!");
        }

        // Initialize the text
        UpdateTapCountText();

        // Subscribe to button click event
        tapButton.onClick.AddListener(IncrementTapCount);
    }

    void IncrementTapCount()
    {
        // Increment the total taps when the button is clicked
        totalTaps++;
        UpdateTapCountText();
    }

    void UpdateTapCountText()
    {
        // Update the UI text with the total taps
        if (tapCountText != null)
        {
            tapCountText.text = "" + totalTaps;
        }
        else
        {
            Debug.LogError("tapCountText is not assigned!");
        }
    }
}
