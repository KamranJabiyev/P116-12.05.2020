using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    class Program
    {
        static void Main(string[] args)
        {
            #region tek ededlerin cemi
            //int n = 5;
            //int m = 14;
            //int sum = 0;
            //for (int i = n; i <= m; i++)
            //{
            //    if (i % 2 == 1)
            //        sum += i;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region n ve m ededleri uzerinde riyazi emeller
            //int n = 22;
            //int m = 2;

            //char simbol = '+';

            //switch (simbol)
            //{
            //    case '+':
            //        Console.WriteLine(n+m);
            //        break;
            //    case '-':
            //        Console.WriteLine(n - m);
            //        break;
            //    case '*':
            //        Console.WriteLine(n * m);
            //        break;
            //    case '/':
            //        Console.WriteLine(n / m);
            //        break;
            //    case '%':
            //        Console.WriteLine(n % m);
            //        break;
            //    default:
            //        Console.WriteLine("Zehmet olmasa riyazi operator daxil edin");
            //        break;
            //}
            #endregion

            #region Array
            //int[] arr = { 1, 23, 45,50,20 };
            //ARRAY METHODS
            //Console.WriteLine(arr.Average());
            //int sum = arr.Sum();
            //Console.WriteLine(sum);
            //Console.WriteLine(arr.Min());
            //Console.WriteLine(arr.Max()+arr.Min());
            //Array.Sort(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //bool isExist = arr.Contains(200);
            //Console.WriteLine(isExist);

            //int[] arr=new int[] { 1, 23, 45 };
            //int[] arr=new int[3] { 1, 23, 1 };
            //int[] arr = new int[5];
            //arr[0] = 1;
            //arr[1] = 144;
            //arr[2] = 12;
            //arr[3] = 1;
            //arr[4] = 135;
            //string[] stu = { "Tural", "Elgun", "Miryasin", "Ulvi" };
            //Console.WriteLine(stu.Rank);
            //Array.Clear(stu,1,3);
            //Array.Reverse(stu);
            //Array.Sort(stu);
            //foreach (string item in stu)
            //{
            //    Console.WriteLine(item);
            //}
            //string result = string.Join("123",stu);
            //Console.WriteLine(result);

            #endregion

            #region array ededi orta chixarmaq
            //int[] arr = { 12, 25, 39, 41, 53,10,100 };
            //int sum = 0;
            //foreach (int i in arr)
            //{
            //    sum += i;
            //}
            //double result = sum / arr.Length;
            //Console.WriteLine(result);
            #endregion

            #region array en boyuk eded
            //int[] arr = { 12, 25,95, 39, 41, 53, 10 };
            //int max = arr[0];
            //int min = arr[0];
            //foreach (int number in arr)
            //{
            //    if (number > max)
            //        max = number;
            //    if (number < min)
            //        min = number;
            //}

            //Console.WriteLine(max+min);
            #endregion

            #region String
            string word = "    Hello,Hi,Salam   "; //{'H','e','l','l','o'}
            string word2 = "Sagol";
            //Console.WriteLine(word.Trim()); //(hp Televizor).tolower  - (HP Televizor).tolower
            //Console.WriteLine(word.ToUpper());
            //Console.WriteLine(word.ToLower());
            //string[] arr = word.Split(',');
            //Console.WriteLine(arr[2]);
            //string rem = word.Remove(4,1);
            //string rep = rem.Replace('e', 'a');
            //Console.WriteLine(rep);
            //Console.WriteLine(word.Replace("el","am"));
            //Console.WriteLine(word.IndexOf('l',5));
            //string newStr = word.Remove(2, 3);
            //Console.WriteLine(newStr);
            //Console.WriteLine(word.LastIndexOf('l'));
            //Console.WriteLine(String.Concat(word, word2));
            //Console.WriteLine(word+" "+word2);
            //Console.WriteLine($"{word} azerbaycanca {word2} demekdir");
            //Console.WriteLine(word.Contains("ye"));
            //Console.WriteLine(word.Length);
            //foreach (char item in word)
            //{
            //    Console.WriteLine(item);
            //}
            //int res=word.CompareTo("Salam");
            //bool res = word.Equals("Salam");
            //Console.WriteLine(res);

            #endregion
        }
    }
}
