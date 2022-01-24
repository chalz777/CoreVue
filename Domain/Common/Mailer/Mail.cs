namespace Web.Services.Mailer
{
    using System.Collections.Generic;
    using System.Net.Mail;

    public class Mail : IMail
    {
        /// <summary>
        /// The value that will go in the subject line of the email.
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// The email text to send.
        /// </summary>
        public string MessageBody { get; set; }
        /// <summary>
        /// Files (represented as byte arrays to attach to the email
        /// </summary>
        public List<Attachment> Attachments { get; set; }

        private bool SendCopy { get; set; }
        private bool SendEmails { get; set; }
        private string CopyAddress { get; set; }
        private string FromAddress { get; set; }
        private string NoReplyAddress { get; set; }
        private string ErrorAddress { get; set; }
        private string PrimarySmtpServer { get; set; }
        private string SecondarySmtpServer { get; set; }
        private HashSet<MailAddress> SendTo { get; set; }
        private HashSet<MailAddress> CopyTo { get; set; }
        private HashSet<MailAddress> BlindCopyTo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Mail()
        {
            InitializeMailer();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sendTo"></param>
        public Mail(MailAddress sendTo) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sendTo"></param>
        /// <param name="copyTo"></param>
        public Mail(MailAddress sendTo, MailAddress copyTo) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sendTo"></param>
        public Mail(HashSet<MailAddress> sendTo) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sendTo"></param>
        /// <param name="copyTo"></param>
        public Mail(HashSet<MailAddress> sendTo, HashSet<MailAddress> copyTo) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sendTo"></param>
        /// <param name="copyTo"></param>
        /// <param name="blindCopyTo"></param>
        public Mail(HashSet<MailAddress> sendTo, HashSet<MailAddress> copyTo, HashSet<MailAddress> blindCopyTo) { }

        public void SendEmail()
        {
            throw new System.NotImplementedException();
        }

        public void To(string email)
        {
            throw new System.NotImplementedException();
        }

        public void To(MailAddress email)
        {
            throw new System.NotImplementedException();
        }

        public void To(IEnumerable<MailAddress> emails)
        {
            throw new System.NotImplementedException();
        }

        public void Copy(string email)
        {
            throw new System.NotImplementedException();
        }

        public void Copy(MailAddress email)
        {
            throw new System.NotImplementedException();
        }

        public void Copy(IEnumerable<MailAddress> emails)
        {
            throw new System.NotImplementedException();
        }

        public void Bcc(string email)
        {
            throw new System.NotImplementedException();
        }

        public void Bcc(MailAddress email)
        {
            throw new System.NotImplementedException();
        }

        public void Bcc(IEnumerable<MailAddress> emails)
        {
            throw new System.NotImplementedException();
        }

        private void InitializeMailer() { }
    }
}
