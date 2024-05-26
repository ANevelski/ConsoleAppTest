namespace MainApp
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("HelperSearch App.");
        }

        public static void HelperSearch(int[] input)
        {

            if (input == null || input.Length < 3)
            {
                throw new ArgumentException("The input array coud not be Null or lenght should be at least 3 or more.");
            }
                       
            List<int> selectedIndex = new List<int>();

            for (int i = 0; i < input.Length - 2; i++)
            {
                int summX2 = (input[i] + input[i + 1])*2;
                if (input[i+2] > summX2)
                {
                    selectedIndex.Add(i + 2);
                }
            }

            if (selectedIndex.Count == 0)
            {
                Console.Write("The indexes were not found.");
            }
            else
            {
                string result = string.Join("; ", selectedIndex.ToArray());
                Console.Write(string.Format("{0} {1}","The folowing indexes were found:", result));
            }            
        }
    }
}
