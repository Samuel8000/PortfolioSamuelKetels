using Portfolio.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Data
{
    public interface IEmailSettingsData
    {
        IEnumerable<EmailSetting> GetAllEmailAccounts();
        EmailSetting UpdateEmailSetting(EmailSetting updatedEmailSetting);
        EmailSetting NewEmailSetting(EmailSetting newEmailSetting);

        EmailSetting GetEmailSettingById(int emailSettingId);
        int Commit();
    }
}
