namespace Portfolio.Utility
{
    public interface IMailer
    {
        void SendEmail(string from, string fromName, string to, string toName, string password, string mailSubject, string mailBody);
    }
}