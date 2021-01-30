using UnityEngine;
using UnityEngine.UI;

public class TimeLive : MonoBehaviour
{
    public float Timer = 120;
    public Text TimeText;

    public void Update()
    {
        if (Timer >= 0)
        {
            Timer -= Time.deltaTime;
        }


        TimeText.text = Timer.ToString();
    }

    private void FixedUpdate()
    {
        
        
    }
}
