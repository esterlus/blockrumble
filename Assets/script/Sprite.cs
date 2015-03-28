using UnityEngine;

public class Sprite : MonoBehaviour {
    private IInput inp = new InputKeyboard();

    private void Update() {
        inp.Update(Time.deltaTime);
        switch (inp.Direction()) {
        case EDirection.West:
            transform.localPosition = new Vector3(transform.localPosition.x - 1.0f, transform.localPosition.y);
            break;
        }
    }
}