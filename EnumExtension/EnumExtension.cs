using System;

namespace EnumExtension
{
    public static class EnumExtension
    {
        public static string EnumNameToDescription<TEnum>(this string Name, Func<string, bool> predicate) where TEnum : Enum
        {
            string dpname = string.Empty;
            try
            {
                Type type = typeof(TEnum);
                if (predicate(Name))
                {
                    dpname = type.GetField(Name).GetCustomAttributesData()[0].ConstructorArguments[0].Value.ToString();
                }
            }
            catch (Exception)
            {
                dpname = string.Empty;
            }

            return dpname;
        }
    }
}
