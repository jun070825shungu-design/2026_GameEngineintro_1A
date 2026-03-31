using UnityEngine;
using TMPro;
public class Card : MonoBehaviour
{

    public float rotateY;
    public TextMeshProUGUI text;
    public bool isClick = false;
    private Quaternion flipRotation = Quaternion.Euler(0, 180f, 0);
    private Quaternion originRotation = Quaternion.Euler(0, 0, 0);


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
        text.text = Random.Range(0, 10).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        // && and || or
        // 0 => 180 => -180 => 0

        //0 < y < 180
        
        float currentY = transform.eulerAngles.y;

        if(isClick)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, flipRotation, rotateY * Time.deltaTime);
            //if (currentY >= 0 && currentY < 180)
            //{
            //    transform.Rotate(0, rotateY, 0);
            //}
        }
        else
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, originRotation, rotateY * Time.deltaTime);
        }

        
        
    }
    public void ClickCard()
    {
        isClick = !isClick;
    }
}
