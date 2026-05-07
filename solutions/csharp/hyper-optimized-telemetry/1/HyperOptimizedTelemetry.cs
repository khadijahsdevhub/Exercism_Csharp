public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] buffer = new byte[9];

        int byteCount;
        bool isSigned;

        if (reading >= 0)
        {
            if (reading <= ushort.MaxValue)
            {
                byteCount = 2;
                isSigned = false;
            }
            else if (reading <= int.MaxValue)
            {
                byteCount = 4;
                isSigned = true;
            }
            else if (reading <= uint.MaxValue)
            {
                byteCount = 4;
                isSigned = false;
            }
            else
            {
                byteCount = 8;
                isSigned = true;
            }
        }
        else
        {
            if (reading >= short.MinValue)
            {
                byteCount = 2;
                isSigned = true;
            }
            else if (reading >= int.MinValue)
            {
                byteCount = 4;
                isSigned = true;
            }
            else
            {
                byteCount = 8;
                isSigned = true;
            }
        }

        buffer[0] = (byte)(isSigned ? 256 - byteCount : byteCount);

        byte[] readingBytes = BitConverter.GetBytes(reading);

        for (int i = 0; i < byteCount; i++)
        {
            buffer[i + 1] = readingBytes[i];
        }

        return buffer;
    }

    public static long FromBuffer(byte[] buffer)
    {
        byte prefix = buffer[0];

        return prefix switch
        {
            2 => BitConverter.ToUInt16(buffer, 1),
            4 => BitConverter.ToUInt32(buffer, 1),

            254 => BitConverter.ToInt16(buffer, 1),
            252 => BitConverter.ToInt32(buffer, 1),
            248 => BitConverter.ToInt64(buffer, 1),

            _ => 0
        };
    }
}