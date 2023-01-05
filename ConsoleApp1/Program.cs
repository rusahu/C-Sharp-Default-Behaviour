using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ParseNullStringToDecimal();
        }

        public static void CheckDefaultDateTime()
        {
            Console.WriteLine(default(DateTime));
            Console.WriteLine(new DateTime());
            Console.WriteLine(DateTime.MinValue);
        }

        public static void CheckStringAttribute()
        {
            var originalString = "original";
            var copyString = originalString;
            originalString = "not original";
            Console.WriteLine(originalString);
            Console.WriteLine(copyString);
        }

        public static void ParseGuid()
        {
            var publicReceiptId = Console.ReadLine();
            var bytes = Convert.FromBase64String(publicReceiptId);
            var strg = System.Text.Encoding.UTF8.GetString(bytes);
            var guid = Guid.Parse(strg);
            Console.WriteLine(guid);
        }

        public static void ParseUTF8()
        {
            var guid =  Console.ReadLine();
            var bytes = System.Text.Encoding.UTF8.GetBytes(guid.ToString());
            var result = Convert.ToBase64String(bytes);
            Console.WriteLine(result);
        }

        public static void ParseNullDate()
        {
            var a = new DateTime().ToString(CultureInfo.InvariantCulture);
            var ReceiptDate = DateTime.ParseExact(null, "yyyy-MM-dd HH:mm:ss", null);
            Console.WriteLine(ReceiptDate);
        }

        public static void ParseNullStringToDecimal()
        {
            var dec = decimal.Parse(null);
            Console.WriteLine(dec);
        }

        public static void PrintBooleanResult()
        {
            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);
            Console.WriteLine();
            Console.WriteLine(true || true);
            Console.WriteLine(true ||false);
            Console.WriteLine(false ||true);
            Console.WriteLine(false || false);
        }

        public static void CheckBooleanLogicUsingBracket()
        {
            var a = true && false || true || false;
            var b = true && (false || true) || false;
            Console.WriteLine(a);
            Console.WriteLine(b);


        }

        public static void CheckEmailAttribute()
        {
            var emails = new List<string>() { "test@123", "", null };
            var emailAttribute = new EmailAddressAttribute();
            foreach (var email in emails)
            {
                Console.WriteLine(emailAttribute.IsValid(email));
            }

        }

    }
}
