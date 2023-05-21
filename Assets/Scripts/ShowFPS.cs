using UnityEngine;

public class ShowFPS : MonoBehaviour
{
    public static float fps;
    public int fontSize = 20;

    void OnGUI()
    {
        fps = 1.0f / Time.deltaTime;
        GUIStyle style = new GUIStyle(GUI.skin.label);
        style.fontSize = fontSize; 

        GUILayout.Label("FPS: " + (int)fps, style);
    }
}
