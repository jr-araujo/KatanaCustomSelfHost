using Owin;
using System.Diagnostics;

namespace KatanaCustomSelfHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseWelcomePage("/");

            app.UseErrorPage();

            app.Run(context =>
            {
                Trace.WriteLine(context.Request.Uri);

                var parametroVersaoQS = context.Request.Query["versao"];

                try
                {
                    var parametroVersao = int.Parse(parametroVersaoQS);
                }
                catch
                {
                    throw new System.Exception("Erro ao converter o número da versão");
                }

                return context.Response.WriteAsync("Olá Mundo, eu sou o servidor Katana (vNext) de versão: " + parametroVersaoQS);
            });
        }
    }
}