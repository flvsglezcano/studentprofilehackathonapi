[assembly: FunctionsStartup(typeof(Startup))]

public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        builder
            .AddScoped<IStudentTableStorageService, TableStorageService>()
            .AddGraphQLFunction()
            .AddQueryType<Query>();
    }
}
