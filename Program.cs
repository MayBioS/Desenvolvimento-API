namespace Api
{
    public class Program
    {
        //método principal, tudo precis ser executado, chama no método principal
        public static void Main(String[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreatHostBuilder(string[] args) =>
            Host.CreatorDefaultBuilder(args).ConfigureWebHostDefalts(web
    Builder =>
    {
        webBuilder.UseStartup<Startup>();
    });
    }
}