using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms{
    class CouponNumbers{
        public static void GenerateCouponNumbers(){
            char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789".ToCharArray();
            Random random = new Random();
            string couponCode = "";

            for (int i = 0; i < chars.Length; i++){
                char c = chars[random.Next(chars.Length)];
                couponCode += c;
             }
            Console.WriteLine(couponCode);

        }
    }
}
