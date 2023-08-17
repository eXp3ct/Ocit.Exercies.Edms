using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Ocit.Exercies.Edms.Infrastructure;
using Ocit.Exezrcies.Emds.Data;

namespace Ocit.Exercies.Edms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Создание DI-контейнера
            var services = new ServiceCollection();

            // Регистрация зависимостей
            ConfigureServices(services);

            // Построение провайдера сервисов
            var serviceProvider = services.BuildServiceProvider();
            var mediator = serviceProvider.GetRequiredService<IMediator>();
            try
            {
                var context = serviceProvider.GetRequiredService<AppDbContext>();
                context.Database.EnsureCreated();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var form = new MainForm(mediator);
            Application.Run(form);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddPersistance();
            services.AddInfrastructure();
        }
    }
}