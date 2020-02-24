using MessagingService.Providers;

namespace MessagingService
{
    public class BL
    {
        //Set this variable based on where the message is sent from
        public int countryId = 5;
        // !!! Remember to Clear !!!

        public void SendMessage(string number,
        string message,
        bool isEmail = false)
        {
            if (isEmail)
            {
                SendGrid.Send(number, message);
            }
            else
            {
                if (countryId == 4)
                {
                    Mitto.Send(number, message);

                }
                else
                    Telesign.Send(number, message);
            }
        }
    }
}
