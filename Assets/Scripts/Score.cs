using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Transform playerPosition;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = playerPosition.position.z.ToString("0");
    }
}
