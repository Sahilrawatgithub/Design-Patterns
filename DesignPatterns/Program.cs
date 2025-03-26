namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Observer Pattern allows multiple objects (Observers) to be notified when another object (Subject) changes its state.");

            NewsPublisher newspublisher = new NewsPublisher();

            ISubscriber emailsub=new EmailSubscriber("sahil");
            ISubscriber smssub = new SMSSubscriber("abhishek");

            newspublisher.AddSubscriber(emailsub);
            newspublisher.AddSubscriber(smssub);

            newspublisher.NotifySubscribers("Sahil made a notification.");

            newspublisher.RemoveSubscriber(emailsub);

            newspublisher.NotifySubscribers("One subscriber removed.");
        }
    }
}
