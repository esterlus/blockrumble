using UnityEngine;

public class Loader : MonoBehaviour {

    private void Start() {
        Load.LoadLevel(Load.Level.Menu);
    }
}