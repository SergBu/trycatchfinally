using System;

namespace trycatchfinnaly
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    throw new Exception("Hello from try");
                }
                catch
                {
                    throw new Exception("Hello from catch");
                }
                finally
                {
                    throw new Exception("Hello from finally");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error message: {ex.Message}");
            }
        }
    }
}
