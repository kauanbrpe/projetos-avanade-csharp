using MinimalApi;

IHostBuilder CreateHostBuildder(string [] args)
{
    return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder.UseStartup<Startup>();
    });
}

CreateHostBuildder(args).Build().Run();