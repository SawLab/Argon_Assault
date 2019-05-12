using UnityEngine;
using UnityEngine.UI;

public class DisplayTime : MonoBehaviour
{
    Text timeText;
    float timer;
    string min;
    string sec;

    void Start()
    {
        timeText = GetComponent<Text>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        min = Mathf.Floor(timer / 60).ToString("00");
        sec = Mathf.Floor(timer % 60).ToString("00");
        timeText.text = min + ":" + sec;
    }
}