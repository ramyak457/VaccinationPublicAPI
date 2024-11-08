﻿using VaccinationAPI.Query;
using GraphQL.Types;

namespace VaccinationAPI.Schemas
{
    public class PopulationSchema: Schema
    {
        public PopulationSchema(IServiceProvider serviceProvider) : base(serviceProvider) 
        {
            Query = serviceProvider.GetRequiredService<PopulationQuery>();
        }
    }
}