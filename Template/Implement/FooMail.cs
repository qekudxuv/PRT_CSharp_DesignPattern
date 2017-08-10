namespace Template
{
    class FooMail : AbstractMailTemplate
    {
        protected override string GetMailContent()
        {
            return "your mail content";
        }

        protected override string GetMailSubject()
        {
            return "your mail subject";
        }

        protected override void SetMailAttachment()
        {
            //_smtpSvc.SetAttachment("attachment file path");
            return;
        }

        protected override void SetMailReceiver()
        {
            _smtpSvc.SetMailTo("abc@xxx.yyy");
        }
    }
}
