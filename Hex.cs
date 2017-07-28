internal static string GetHexFromBytes(byte[] arr)
{
    var sb = new StringBuilder();
    foreach (var b in arr)
    {
        sb.Append(b.ToString("x2"));
    }
    return sb.ToString();
}

internal static byte[] GetBytesFromHex(string hex)
{
    if (hex.Length % 2 != 0)
    {
        throw new ArgumentException($"hex must be even length (is {hex.Length})", nameof(hex));
    }
    var ret = new byte[hex.Length / 2];
    for (var i = 0; i < ret.Length; ++i)
    {
        ret[i] = byte.Parse(hex.Substring(i * 2, 2), NumberStyles.HexNumber);
    }
    return ret;
}