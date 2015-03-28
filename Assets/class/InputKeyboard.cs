using UnityEngine;

public class InputKeyboard : IInput {
    private EDirection lastDir = EDirection.None;

    public EDirection Direction() {
        EDirection v = lastDir;
        lastDir = EDirection.None;
        return v;
    }

    public void Update(float delta) {
        float hor = Input.GetAxis("Horizontal");
        if (hor < 0.0f) {
            lastDir = EDirection.West;
        } else if (hor > 0.0f) {
            lastDir = EDirection.East;
        }
    }
}