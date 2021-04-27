using System;
namespace Program
{
    public class MyException:ApplicationException
    {
        public void MyIndexOutOfRangeException()
        {
            Console.WriteLine("Exception occured, index is out of range");
        }
    }
    public class Class6
    {
        public static void Main()
        {
            int []a=new int[2];
            try
            {
                if(1==1){
                
                throw new MyException();
                }
            }
            catch(MyException ex)
            {
                ex.MyIndexOutOfRangeException();
            }
            Console.ReadLine();
        }
    }
}