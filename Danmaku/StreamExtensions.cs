using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlateChef.Danmaku
{
    internal static class StreamExtensions
    {
        public static async Task<bool> ReadBAsync(this Stream stream, byte[] buffer, int offset, int count, CancellationToken ct)
        {
            if (offset + count > buffer.Length)
                throw new ArgumentException();
            int read = 0;
            while (read < count)
            {
                var available = await stream.ReadAsync(buffer, offset, count - read, ct);
                if (available == 0)
                {
                    return false;
                }
                //                if (available != count)
                //                {
                //                    throw new NotSupportedException();
                //                }
                read += available;
                offset += available;
            }

            return true;
        }
    }
}
