using System;

namespace DemoParameters
{
    class Program
    {
        static void Main()
        {
            int ix = 0;
            do
            {
                string bean = "Hello";
                Console.WriteLine("This is my string before: "+bean);

                switch (ix)
                {
                    case 0:
                        ByVal(bean);
                        Console.WriteLine("...and this is the string outside of ByVal: " + bean);
                        break;
                    case 1:
                        TestRef(ref bean);
                        Console.WriteLine("After TestRef: " + bean);
                        break;
                    case 2:
                        string[] beany = { bean, "Hi" };
                        Console.WriteLine("And now, it's part of an array!");
                        Console.WriteLine("And the 2nd entry in the array is " + beany[1]);
                        TestArray(beany);
                        Console.WriteLine("And this is the array after TestArray: {0}, and {1}",
                            beany[0],beany[1]);
                        break;
                    case 3:
                        TestOut(out bean);
                        Console.WriteLine("Now, after TestOut, the string is: "+ bean);
                        break;
                    case 4:
                        Console.WriteLine("...calling TestOptional with this value...");
                        TestOptional(bean);
                        Console.WriteLine("Now, doing TestOptional without any explicit value in the string!");
                        break;
                    case 5:
                        Console.WriteLine("TestMultiple, now, w/ nothing in it!");
                        TestMultiple();
                        Console.WriteLine("TestMultiple, again, but w/ MY string in it!");
                        TestMultiple(bean);
                        break;
                    case 6:
                        Console.WriteLine("Trying TestOverloaded with that string:");
                        TestOverloaded(bean);
                        Console.WriteLine("Now, trying it with the number 12");
                        TestOverloaded(12);
                        break;
                }
                ix++;
                Console.WriteLine();
            } while (ix < 10);
            
        }
        
        static void ByVal(string strung)
        {
            strung = strung + " Mr. Val!";
            Console.WriteLine("This is the string inside ByVal: "+strung);
        }

        static void TestRef(ref string strung)
        {
            strung = strung + " Mr. Ref";
            Console.WriteLine("This is the string inside TestRef: " + strung);
        }
        public static void TestArray(string[] anArray)
        {
            int ix = 101;
            anArray[0] =String.Format("{0}", ix);
            Console.WriteLine("In Test that 1st entry is {0}", anArray[0]);
        }

        public static void TestOut(out String bean)
        {
            Console.WriteLine("I cannot access the string inside TestOut, at the moment!");
            bean = "Out, now!";
            Console.WriteLine("Now, inside TestOut, the string is: "+bean);
        }
        
        static void TestOptional(string bean = "bean")
        {
            Console.WriteLine("In TestOptional, the string is" + bean);
        }

        static void TestMultiple(string a = "string", string b="bean")
        {
            Console.WriteLine("The 1st variable is {0}, & the 2nd is {1}", a, b);
            Console.WriteLine("...so far as TestMultiple is concerned");
        }

        static void TestOverloaded(string strung)
        {
            Console.WriteLine("Adding {0} to 4: {1}", strung, strung + "4");
        }

        static void TestOverloaded(int ix)
        {
            Console.WriteLine("Adding {0} to 4: {1}", ix, ix + 4);
        }
    }
}
