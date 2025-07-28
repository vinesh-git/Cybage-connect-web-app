using CybageConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybageConnectModels
{
    public class ProjectInsightsUser
    {
        public static void DisplayProjectInsights(int id)
        {
            IEnumerable<ProjectInsightsOfUser> projectInsightsOfUsers = UserProjectInsights.GetProjectInsights(id);
            foreach (var projectInsight in projectInsightsOfUsers)
            {
                Console.WriteLine($"ProjectInsight ID: {projectInsight.ProjectInsightId},ProjectInsight: {projectInsight.ProjectInsight}, PublishedDate: {projectInsight.PublishedDateOfProjectInsight}");
            }
        }
        public static void AddProjectInsights(int id, string UserName, string projectInsight)
        {
            ProjectInsightsOfUser projectInsightsOfUsers = new ProjectInsightsOfUser()
            {
                UserId = id,
                UserName = UserName,
                ProjectInsight = projectInsight,
                PublishedDateOfProjectInsight = DateTime.Now,
            };
            UserProjectInsights.AddProjectInsight(projectInsightsOfUsers);
        }
    }
}
