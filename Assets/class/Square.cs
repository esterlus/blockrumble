internal class Square {
    internal int X { get; private set; }
    internal int Y { get; private set; }

    internal void AddX(int diff) {
        X += diff;
    }

    internal void AddY(int diff) {
        Y += diff;
    }
}