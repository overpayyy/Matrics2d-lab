#nullable disable
namespace Matrics2dLib;

// immutable 2x2 matrix
public class Matrix2d : IEquatable<Matrix2d>
{
    private int _a, _b, _c, _d;

    // constructors
    public Matrix2d(int a, int b, int c, int d)
    {
        _a = a;
        _b = b;
        _c = c;
        _d = d;
    }

    public Matrix2d() :this(1, 0, 0, 1) { }

    //properties
    public int A => _a;
    public int B => _b;
    public int C => _c;
    public int D => _d;

    public static Matrix2d Id = new Matrix2d();

    public static Matrix2d Zero = new Matrix2d(0, 0, 0, 0);

    // methods
    override public string ToString() => $"[{_a}, {_b}]\n[{_c}, {_d}]";

    public bool Equals(Matrix2d other)
    {
        if (other is null) return false;
        return _a == other._a && _b == other._b && _c == other._c && _d == other._d;
    }
}

