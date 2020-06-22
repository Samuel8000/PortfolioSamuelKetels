using Microsoft.EntityFrameworkCore;
using Portfolio.Core;
using System.Collections.Generic;

namespace Portfolio.Data
{
    public class SqlEmailSettingsData : IEmailSettingsData
    {
        private readonly PortfolioDbContext _context;


        public SqlEmailSettingsData(PortfolioDbContext context)
        {
            _context = context;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public IEnumerable<EmailSetting> GetAllEmailAccounts()
        {
            return _context.EmailSettings;
        }

        public EmailSetting GetEmailSettingById(int emailSettingId)
        {
            return _context.EmailSettings.Find(emailSettingId);
        }

        public EmailSetting NewEmailSetting(EmailSetting newEmailSetting)
        {
            _context.Add(newEmailSetting);
            return newEmailSetting;
        }

        public EmailSetting UpdateEmailSetting(EmailSetting updatedEmailSetting)
        {
            var entity = _context.EmailSettings.Attach(updatedEmailSetting);
            entity.State = EntityState.Modified;
            return updatedEmailSetting;
        }
    }
}
