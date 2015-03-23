using UnityEngine;

public class GUILoader : MonoBehaviour {

    private void Start() {
    }

    private void Update() {
    }

    private void OnGUI() {
        GUILayout.BeginArea(Layout.Whole);
        Layout.OpenVertical();
        Layout.OpenHorizontal();
        if (GUILayout.Button("Tank")) {
            Load.LoadLevel(Load.Level.Arena);
        }

        Layout.CloseHorizontal();
        Layout.CloseVertical();
        GUILayout.EndArea();
    }
}