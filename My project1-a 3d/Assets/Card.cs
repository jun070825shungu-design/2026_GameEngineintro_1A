using UnityEngine;
using TMPro;
public class Card : MonoBehaviour
{

    public float rotateY;
    public TextMeshProUGUI text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
        text.text = Random.Range(0, 10).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateY, 0);
    }
}
