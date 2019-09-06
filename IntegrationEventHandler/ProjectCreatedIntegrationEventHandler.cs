using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore.CAP;
using Recommend.API.Data;
using Recommend.API.IntegrationEvents;

namespace Recommend.API.IntegrationEventHandler
{
    public class ProjectCreatedIntegrationEventHandler : ICapSubscribe
    {
        private RecommendDbContext _context;
        public ProjectCreatedIntegrationEventHandler(RecommendDbContext context)
        {
            _context = context;
        }
        [CapSubscribe("projectapi.projectcreated")]
        public async Task CreateRecommendFromProject(ProjectCreatedIntergrationEvent @event)
        {
            await Task.CompletedTask;
        }
    }
}
