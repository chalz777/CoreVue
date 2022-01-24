namespace Web.Services.Mailer
{
    using System.Collections.Generic;
    using System.Net.Mail;

    public interface IMail
    {
        /// <summary>
        /// The subject of the message.
        /// </summary>
        string Subject { get; set; }

        /// <summary>
        /// The message body of the email.
        /// </summary>
        string MessageBody { get; set; }

        /// <summary>
        /// Any attachments that will be sent with the mail.
        /// </summary>
        List<Attachment> Attachments { get; set; }

        /// <summary>
        /// Action method to send the email to the client.
        /// </summary>
        void SendEmail();

        /// <summary>
        /// Given a string, set the recipient.
        /// </summary>
        /// <param name="email"></param>
        void To(string email);

        /// <summary>
        /// Given a mail address set the recipient
        /// </summary>
        /// <param name="email"></param>
        void To(MailAddress email);

        /// <summary>
        /// Given a list of emails set the recipients.
        /// Duplicate Entries will be removed.
        /// </summary>
        /// <param name="emails"></param>
        void To(IEnumerable<MailAddress> emails);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        void Copy(string email);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        void Copy(MailAddress email);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="emails"></param>
        void Copy(IEnumerable<MailAddress> emails);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        void Bcc(string email);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        void Bcc(MailAddress email);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="emails"></param>
        void Bcc(IEnumerable<MailAddress> emails);
    }
}
