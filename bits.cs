public class Bits
{
    private readonly bool[] _bits;

    public static implicit operator Bits(long value)
    {
        var bits = new bool[64];
        for (int i = 0; i < 64; i++)
        {
            bits[i] = (value & (1L << i)) != 0;
        }
        return new Bits(bits);
    }

    public static implicit operator Bits(int value)
    {
        var bits = new bool[32];
        for (int i = 0; i < 32; i++)
        {
            bits[i] = (value & (1 << i)) != 0;
        }
        return new Bits(bits);
    }

    public static implicit operator Bits(byte value)
    {
        var bits = new bool[8];
        for (int i = 0; i < 8; i++)
        {
            bits[i] = (value & (1 << i)) != 0;
        }
        return new Bits(bits);
    }
}
