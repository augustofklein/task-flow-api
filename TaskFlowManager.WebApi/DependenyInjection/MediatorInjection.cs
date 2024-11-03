namespace TaskFlowManager.WebApi.DependenyInjection
{
    public static class MediatorInjection
    {
        public static IServiceCollection AddMediatorInjection(this IServiceCollection services)
        {
            var assembly = AppDomain.CurrentDomain.Load("TaskFlowManager.Application");

            services.AddMediatR(config => config.RegisterServicesFromAssembly(assembly));

            return services;
        }
    }
}
