namespace GenericApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emailTask = new EmailTask()
            {
                Message = "Hello, this is a test email",
                Recipient = "mondlik313@gmail.com"
            };

            var reportTask = new ReportTask()
            {
                ReportName = "Annual Report"
            };

            var emailProccessor = new TaskProcessor<EmailTask, string>(emailTask);
            var reportProccessor = new TaskProcessor<ReportTask, string>(reportTask);

            Console.WriteLine(emailProccessor.Execute());
            Console.WriteLine(reportProccessor.Execute());
        }
    }
}
