using System.ComponentModel;

namespace HackerRank.Solutions
{
    public static class Extensions
    {
        public static string ToDescription(this Enum value)
        {
            var fileInfo = value.GetType().GetField(value.ToString());
            var attributes = (DescriptionAttribute[])fileInfo!.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return (attributes != null && attributes.Length > 0) ? attributes[0].Description : value.ToString();
        }
    }
}
