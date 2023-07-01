using UnityEngine;

public class ScreenshotTaker : MonoBehaviour
{
    public void TakeScreenshot() 
    {
        var currentDate = System.DateTime.Now;

        ScreenCapture.CaptureScreenshot(currentDate.Second.ToString() + "-" + currentDate.Day.ToString() + "-" + currentDate.Month.ToString() + "-" + currentDate.Year.ToString() +  ".png");
    }
}
