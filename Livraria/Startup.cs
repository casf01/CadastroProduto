using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Livraria
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            //Vamos adicionar o serviço de mvc para o nosso projeto funcionar
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            /*
            Para usar os arquivos que estão na pasta wwwroot, tais como
            imagens, arquivos css,arquivos de javascript entre outros
            é necessário usar os serviço de ativação dos 
            arquivos estáticos.
             */
             app.UseStaticFiles();


          //Vamos usar o serviço de mvc
          app.UseMvc(route => {
              route.MapRoute(
                  name:"default",
                  template:"{controller=Home}/{action=Index}/{Id?}"
              );
          });
        }
    }
}
