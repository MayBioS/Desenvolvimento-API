namespace Api{
    public class Program{
        //método principal, tudo que precisa executado, chama no método principal
        public static void Main(String[] args){
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>{
                webBuilder.UseStartup<Startup>();
            });
    }
}
