namespace DP.Template
{
    public interface ISmtpService
    {
        string Subject { get; set; }
        bool IsBodyHtml { get; set; }
        global::System.Net.Mail.MailPriority MailPriority { get; set; }

        void AddAttachment(string attachmentPath);
        void SetAttachment(string attachmentPath);
        void ClearAttachment();

        void AddMailTo(string mailAddress);  
        void AddCcTo(string mailAddress);
        void AddBccTo(string mailAddress);

        void ClearMailTo();
        void ClearCcTo();
        void ClearBccTo();

        void SetMailTo(string mailAddress);
        void SetCcTo(string mailAddress);
        void SetBccTo(string mailAddress);
        
        string GetMailTo(string sep);        
        string GetCcTo(string sep);
        string GetBccTo(string sep);        
        
        void SendMail(string content);
        void SendMail(string subject, string content);
        void SendMail(string subject, global::System.Text.StringBuilder content);
        void SendMail(global::System.Text.StringBuilder content);        
        
        void SetMailFrom(string fromName, string mailFrom);
        void SetMailFrom(string mailFrom);  
    }
}
