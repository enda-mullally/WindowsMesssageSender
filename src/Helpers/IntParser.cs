using System;

namespace WinMessageSender.Helpers
{
    public sealed class IntParser
    {
        public static int ParseInt32(string intValue)
        {
            try
            {
                var clean = intValue.Trim();

                return clean.StartsWith("0x")
                    ? Convert.ToInt32(clean, 16)
                    : Convert.ToInt32(clean);
            }
            catch
            {
                return 0;
            }
        }
    }
}
