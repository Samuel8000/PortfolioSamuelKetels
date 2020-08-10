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
        Certificate GetCertificateById(int certificateId);
        Certificate Update(Certificate updatedCertificate);
        Certificate Add(Certificate newCertificate);
        Certificate Delete(int certificateId);
        int HighestId();
        int Commit();
    }

}
