using Portfolio.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Data
{
    public interface IAboutMeData
    {
        IEnumerable<AboutMeInfo> GetAllEntries();
        AboutMeInfo AddNewInfo(AboutMeInfo newInfo);
        AboutMeInfo EditInfo(AboutMeInfo updatedInfo);
        AboutMeInfo GetAboutMeInfoById(int infoId);

        AboutMeInfo GetAboutMeInfoLive();
        int Commit();
    }
}
