namespace MFALogger
{
    public static class DualWriter
    {
        private static int i=0;
        private static System.IO.TextWriter logger =new System.IO.StreamWriter("./DotFiles/ExecutionLog.txt");
        public static void Write(string s)
        {
            System.Console.Write(s);
            logger.Write(s);
            ++i;
            if(i==20)
            {
                logger.Flush();
                i=0;
            }
        }
        public static void WriteLine(string s)
        {
            System.Console.WriteLine(s);
            logger.WriteLine(s);
            ++i;
            if(i==20)
            {
                logger.Flush();
                i=0;
            }
        }

    }
}