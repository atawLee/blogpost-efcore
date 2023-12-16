using EFSampleProject.context;
using Microsoft.Extensions.DependencyInjection;

namespace EFSampleProject;

public static class Configuration
{
    public static void AddDbContext(this IServiceCollection collection)
    {
        collection.AddDbContext<BbsContext>();
    }

}