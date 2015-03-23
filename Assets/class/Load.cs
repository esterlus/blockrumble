using UnityEngine;

public class Load {

    public enum Level {
        Menu,
        Arena,
    }

    public static void LoadLevel(Level level) {
        switch (level) {
        default:
            Application.LoadLevel(level.ToString());
            break;
        }
    }
}