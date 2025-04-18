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

    #region Equals
    public bool Equals(Matrix2d other)
    {
        if (other is null) return false;
        return _a == other._a && _b == other._b && _c == other._c && _d == other._d;
    }

    public static bool operator ==(Matrix2d left, Matrix2d right) => left.Equals(right);
    public static bool operator !=(Matrix2d left, Matrix2d right) => !left.Equals(right);
    #endregion

    #region Arithmetic
    public static Matrix2d operator +(Matrix2d left, Matrix2d right)
    => new Matrix2d(left._a + right._a,
                    left._b + right._b,
                    left._c + right._c,
                    left._d + right._d);

    public static Matrix2d operator -(Matrix2d left, Matrix2d right)
        => new Matrix2d(left._a - right._a,
                        left._b - right._b,
                        left._c - right._c,
                        left._d - right._d);

    public static Matrix2d operator *(Matrix2d left, Matrix2d right)
        => new Matrix2d(left._a * right._a + left._b * right._c,
                        left._a * right._b + left._b * right._d,
                        left._c * right._a + left._d * right._c,
                        left._c * right._b + left._d * right._d);

    public static Matrix2d operator *(int k, Matrix2d matrix)
    => new Matrix2d(k * matrix._a, k * matrix._b, k * matrix._c, k * matrix._d);
    public static Matrix2d operator *(Matrix2d matrix, int k)
        => new Matrix2d(matrix._a * k, matrix._b * k, matrix._c * k, matrix._d * k);
    public static Matrix2d operator -(Matrix2d matrix)
        => new Matrix2d(-matrix._a, -matrix._b, -matrix._c, -matrix._d);
    #endregion

    #region Konwersje

    // konwersja jawna z Matrix2d na int[,]
    public static explicit operator int[,](Matrix2d m)
        => new int[,] { { m._a, m._b }, { m._c, m._d } };

    // konwersja niejawna z int[,] na Matrix2d
    public static implicit operator Matrix2d(int[,] m)
        => new Matrix2d(m[0, 0], m[0, 1], m[1, 0], m[1, 1]);
    #endregion

    #region Transpose
    // metoda transpozycji
    public static Matrix2d Transpose(Matrix2d matrix)
    {
        return new Matrix2d(matrix._a, matrix._c, matrix._b, matrix._d);
    }
    #endregion

    #region Determinant
    // wyznacznik jako metoda statyczna
    public static int Determinant(Matrix2d matrix)
    {
        return matrix._a * matrix._d - matrix._b * matrix._c;
    }

    // wyznacznik jako metoda instancji
    public int Det()
    {
        return _a * _d - _b * _c;
    }
    #endregion

    #region Parse
    // metoda parsowania
    public static Matrix2d Parse(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            throw new FormatException("Input string is null or empty.");

        // Walidacja formatu
        if (!input.StartsWith("[") || !input.EndsWith("]") || input.Count(c => c == '[') != 2 || input.Count(c => c == ']') != 2)
            throw new FormatException("Invalid format.");

        // Usuwanie nawiasów i dzielenie
        input = input.Trim('[', ']');
        var rows = input.Split("], [");
        if (rows.Length != 2)
            throw new FormatException("Invalid format.");

        try
        {
            var row1 = rows[0].Split(',').Select(int.Parse).ToArray();
            var row2 = rows[1].Split(',').Select(int.Parse).ToArray();

            if (row1.Length != 2 || row2.Length != 2)
                throw new FormatException("Invalid matrix dimensions.");

            return new Matrix2d(row1[0], row1[1], row2[0], row2[1]);
        }
        catch
        {
            throw new FormatException("Invalid format.");
        }
    }
    #endregion
}

