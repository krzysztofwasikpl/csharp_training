using System;

namespace event_handling_using_delegates
{
    public delegate void MyBroadcastEvent(string userInputNumber);

    public class BroadcastPublisher
    {
        private string input;
        public event MyBroadcastEvent notificationEvent;
        public event EventHandler<string> notificationEventVersion2;

        public string InputChanged
        {
            set
            {
                this.input = value;
                notificationEvent(this.input);
                notificationEventVersion2(this, this.input);
            }
        }
    } 

    class MainClass
    {
        

        public static void Main(string[] args)
        {
            Console.WriteLine("project: event_handling_using_delegates");

            var inputTracker = new BroadcastPublisher();
            inputTracker.notificationEvent += ResponseOnNotification;
            inputTracker.notificationEvent += delegate (string addInput)
            {
                Console.WriteLine("Addidtion notification= " + addInput);
            };

            inputTracker.notificationEventVersion2 += delegate (object sender, string addInput)
            {
                Console.WriteLine("Publisher: " + sender.GetType());
                Console.WriteLine("Additional notification from version2= " + addInput );
            };

            string consoleInput;
            do
            {
                Console.WriteLine("Please enter data. For application exit please enter phrase exit");
                consoleInput = Console.ReadLine();

                if("exit" != consoleInput)
                {
                    inputTracker.InputChanged = consoleInput;
                }

            } while ("exit" != consoleInput);

        }

        static void ResponseOnNotification(string input)
        {
            Console.WriteLine("User provided data= " + input);
        }
    }
}
