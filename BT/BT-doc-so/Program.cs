using System;
namespace HelloWorld
{
    public class docSoThanhChu
    {
        public static void Main()
        {
            Console.WriteLine("nhap so:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(docso(number));
        }
        public static string doc1so(int num)
        {
            string doc = "doc1so";
            switch (num)
            {
                case 0:
                    doc = "";
                    break;
                case 1:
                    doc = "one";
                    break;
                case 2:
                    doc = "two";
                    break;
                case 3:
                    doc = "three";
                    break;
                case 4:
                    doc = "four";
                    break;
                case 5:
                    doc = "five";
                    break;
                case 6:
                    doc = "six";
                    break;
                case 7:
                    doc = "seven";
                    break;
                case 8:
                    doc = "eight";
                    break;
                case 9:
                    doc = "night";
                    break;
            }

            Console.WriteLine($"Doc 1 so: {doc}");

            return doc;
        }

        public static string doc2SoLonhon20(int num)
        {
            string doc = "doc2so";
            switch (num / 10)
            {
                case 2:
                    doc = "twenty " + doc1so(num % 10);
                    break;
                case 3:
                    doc = "thirty " + doc1so(num % 10);
                    break;

                case 4:
                    doc = "forty " + doc1so(num % 10);
                    break;

                case 5:
                    doc = "fifty " + doc1so(num % 10);
                    break;

                case 8:
                    doc = "eighty " + doc1so(num % 10);
                    break;


                default:
                    doc = doc1so(num / 10) + "ty " + doc1so(num % 10);
                    break;
            }

            Console.WriteLine($"Doc 2 so: {doc}");

            return doc;
        }
        public static string doc2sonhohon20(int num)
        {
            string doc = "doc2sonhohon20";
            switch (num)
            {
                case 10:
                    doc = "ten";
                    break;
                case 11:
                    doc = "eleven";
                    break;
                case 12:
                    doc = "twelve";
                    break;
                case 13:
                    doc = "thirteen";
                    break;
                case 15:
                    doc = "fiften";
                    break;

                default:
                    doc = doc1so(num / 10) + "teen";
                    break;

            }
            return doc;
        }

        public static string doc3so(int num)
        {
            string doc = "doc3so";
            string duoi = (num % 100 > 20) ? "and " + doc2SoLonhon20(num % 100) : (num % 100 > 10) ? "and " + doc2sonhohon20(num % 100) : "and " + doc1so(num % 100);
            doc = doc1so(num / 100) + " hundreeds" + duoi;
            return doc;
        }
        public static string docso(int num)
        {
            string doc = "docso";
            if (num == 0) { doc = "zero"; }
            else if (num < 10) { doc = doc1so(num); }
            else if (num <= 20) { doc = doc2sonhohon20(num); }
            else if (num < 100) { doc = doc2SoLonhon20(num); }
            else if (num < 1000) { doc = doc3so(num); }
            else { doc = "jjjjjjj"; }
            return doc;
        }


    }

}