using System;
using System.ComponentModel;

namespace EnumExtension
{
    public enum Customer
    {
        [Description("VIP")]
        A,
        [Description("高級顧戶")]
        B,
        [Description("一般顧戶")]
        C,
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "A", "B", "C" };

            foreach (var item in arr)
            {
                Console.WriteLine($"當前顧客級別： {item.EnumNameToDescription<Customer>(s => !string.IsNullOrWhiteSpace(s))}");
            }

            Console.ReadLine();
        }
    }
}
