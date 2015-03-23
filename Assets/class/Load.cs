using UnityEngine;

public class Load {

    public enum Level {
        Menu,
    }

    public static void LoadLevel(Level level) {
        switch (level) {
        case Level.Menu:
            Application.LoadLevel(level.ToString());
            break;
        default:
            break;
        }
    }
}