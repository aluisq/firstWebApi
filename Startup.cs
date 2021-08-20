using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using firstWebApi.Data;
using firstWebApi.Data.UserRepository;
using firstWebApi.Models;
using firstWebApi.Services;
using firstWebApi.Services.User;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace firstWebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            // Registrando o contexto do Banco na aplicação
            services.AddDbContext<DataContext>(
                context => context.UseSqlite(Configuration.GetConnectionString("Default"))
            );


            // // Authorization c/ JWT aplicando o tipo de comportamente para validação do Token
            // services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //     .AddJwtBearer(options => 
            //     {
            //         options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters{
            //             ValidateIssuerSigningKey = true,
            //             IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII
            //             .GetBytes(Configuration.GetSection("AppSetting: SecretKey").Value))
            //         };
            //     }
            // );


            // // Registro de usuario pela aplicação
            // IdentityBuilder builder = services.AddIdentityCore<Usuario>(options => 
            //     {
            //         // Remover ao máximo o que é padrão

            //         // Caracteres Especiais
            //         options.Password.RequireDigit = false;
                    
            //         // Numeros e letras
            //         options.Password.RequireNonAlphanumeric = false;
                    
            //         //Letras minusculas 
            //         options.Password.RequireLowercase = false;

            //         // Letras maiusculas
            //         options.Password.RequireUppercase = false;

            //         // Tamanho minimo da senha
            //         options.Password.RequiredLength = 4;
            //     }
            // );

            // builder = new IdentityBuilder(builder.UserType, typeof(Usuario), builder.Services);


            // Precisa IMPLEMENTAR O BUILDER
            //+
            //+
            // .............
            

            // ADDMVC -  Série de configurações automaticamente prontas, como autorização, mapeamento, views, mecanismo do Razor, etc.
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            // Implemetar os controllers Criados
            services.AddControllers();
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "firstWebApi", Version = "v1" });
            });
            
            // Registrando as Interfaces
            services.AddScoped<IPokemonService, PokemonService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "firstWebApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
