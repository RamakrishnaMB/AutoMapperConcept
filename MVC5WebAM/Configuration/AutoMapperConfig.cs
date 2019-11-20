using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;


namespace MVC5WebAM.Configuration
{
    public class AutoMapperConfig
    {
        protected readonly IMapper _mapper;


        public AutoMapperConfig()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                var profiles = GetProfiles();
                foreach (var profile in profiles)
                {
                    cfg.AddProfile((Activator.CreateInstance(profile) as Profile));
                }
            });
            configuration.CompileMappings();
            _mapper = configuration.CreateMapper();
        }
        private static IEnumerable<Type> GetProfiles()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(f => f.FullName.Contains("BuisnessLayer"));
            foreach (var assembly in assemblies)
            {
                try
                {
                    foreach (var type in assembly.GetTypes().Where(type => type.GetConstructors().Any(c => c.GetParameters().Count() == 0)
                         && !type.IsAbstract && typeof(Profile).IsAssignableFrom(type)))
                    {
                        yield return type;
                    }
                }
                finally { }
            }

        }

        public static void Configure()
        { }

    }
}