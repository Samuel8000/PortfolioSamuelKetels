using Portfolio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portfolio.Data
{
    public interface ICertificateData
    {
        IEnumerable<Certificate> GetAllCertificates();
        IEnumerable<Certificate> GetCertificatesBySkill(int skillId);
    }

}
