using System;

namespace URLEncoder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string project_name = " ";
            string activity_name = " ";

            try
            {
                Console.WriteLine("Please enter the project name");
                project_name = Console.ReadLine();


                Console.WriteLine("Now enter the activity name");
                activity_name = Console.ReadLine();

                project_name = project_name.Replace(" ", "");
                activity_name = activity_name.Replace(" ", "");

                string url = "https://companyserver.com/content/" + project_name + "/files/" + activity_name + "/" + activity_name + "Report.pdf";
                Console.WriteLine("\n");
                Console.WriteLine(url);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("PLease enter vaild details");
            }
        }
    }
}
