namespace Packt.Shared;
public class DisplacementVector
{
    public int X;
    public int Y;

    public DisplacementVector(int initialX, int initialY)
    {
        X = initialX;
        Y = initialY;
    }

    public static DisplacementVector operator +(
        DisplacementVector vector1,
        DisplacementVector vector2)
    {
        return new(
            vector1.X + vector2.X,
            vector2.Y + vector1.Y);
    }

    
}
