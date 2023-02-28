[assembly: FunctionsStartup(typeof(Startup))]

public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {

        builder
            .AddGraphQLFunction()
            .AddQueryType<Query>();
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<GraphQLSPP.Service.IStudentTableStorageService, GraphQLSPP.Service.StudentStorageService>();
    }


}
