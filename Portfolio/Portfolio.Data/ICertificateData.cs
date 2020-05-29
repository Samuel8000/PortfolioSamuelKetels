using Portfolio.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Data
{
    public interface ICertificateData
    {
        IEnumerable<Certificate> GetAllCertificates();
    }
}
