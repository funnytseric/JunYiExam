using System;

namespace JunYiExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string testStr = "junyiacademy";
            Console.WriteLine(testStr);
            Console.WriteLine(ExamClass.RevertString(testStr));
            Console.WriteLine();

            testStr = "flipped class room is important";
            Console.WriteLine(testStr);
            Console.WriteLine(ExamClass.RevertSpelling(testStr));
            Console.WriteLine();

            int testNum = 15;
            for (int i = 1; i <= testNum; i++)
                Console.Write(i + ", ");
            Console.WriteLine();
            Console.WriteLine(ExamClass.GetNumberCountByRule(testNum));
        }

        public class ExamClass
        {
            //1.A 反轉整個字串
            public static string RevertString(string str)
            {
                char[] buffer = new char[str.Length];
                for (int i = 0; i < str.Length; i++)
                    buffer[str.Length - 1 - i] = str[i];//直接從字串反向取 char 出來放到 buffer

                return new string(buffer);//回傳反轉完的字串
            }

            //1.B 反轉單字
            public static string RevertSpelling(string str)
            {
                string[] words = str.Split(" ");//把字串用空白分割
                string revertResult = "";

                foreach(string word in words)
                {
                    revertResult += ExamClass.RevertString(word) + " ";//因為反轉字串內部的函數可以重複使用，直接呼叫，並用空白串起來
                }

                return revertResult.Remove(revertResult.Length -1);//移除最後一個空白然後回傳
            }

            //計算符合規則數字數量
            public static int GetNumberCountByRule(int inputNum)
            {
                int quot3 = inputNum / 3;
                int quot5 = inputNum / 5;
                int quot15 = inputNum / 15;

                //扣掉3的倍數的個數，再扣掉5的倍數的個數，最後加上兩倍的15的倍數的個數(因為被扣兩次)
                int count = inputNum - quot3 - quot5 + 2 * quot15;

                return count;
            }
        }


    }
}
