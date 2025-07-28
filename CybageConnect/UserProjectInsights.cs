using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybageConnect
{
    public class UserProjectInsights
    {
        public static IEnumerable<ProjectInsightsOfUser> GetProjectInsights(int id)
        {
            CybageConnectLinqDataContext context = new CybageConnectLinqDataContext();
            IEnumerable<ProjectInsightsOfUser> user = context.ProjectInsightsOfUsers.Where(u => u.UserId == id);
            return user.ToList();
        }
        public static void AddProjectInsight(ProjectInsightsOfUser ProjectInsightsOfUser)
        {
            CybageConnectLinqDataContext context = new CybageConnectLinqDataContext();
            context.ProjectInsightsOfUsers.InsertOnSubmit(ProjectInsightsOfUser);
            context.SubmitChanges();
        }
    }
}
