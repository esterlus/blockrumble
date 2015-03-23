using UnityEngine;

public class Layout {

    public static void OpenVertical(bool withFlexibleSpace = true) {
        GUILayout.BeginVertical();
        if (withFlexibleSpace) {
            GUILayout.FlexibleSpace();
        }
    }

    public static void OpenHorizontal(bool withFlexibleSpace = true) {
        GUILayout.BeginHorizontal();
        if (withFlexibleSpace) {
            GUILayout.FlexibleSpace();
        }
    }

    public static void CloseVertical(bool withFlexibleSpace = true) {
        if (withFlexibleSpace) {
            GUILayout.FlexibleSpace();
        }
        GUILayout.EndVertical();
    }

    public static void CloseHorizontal(bool withFlexibleSpace = true) {
        if (withFlexibleSpace) {
            GUILayout.FlexibleSpace();
        }
        GUILayout.EndHorizontal();
    }

    public static Rect Whole = new Rect(0.0f, 0.0f, Screen.width, Screen.height);
}