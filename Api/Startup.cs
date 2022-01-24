using AutoMapper;
using Core.Mapper;
using Web.Security.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SSRNM.Global;
using SSRNMFSSN.Data.Models;
using Web.Global.Mapper;
using KDT.Core.Authentication.ClientCertificate;
using KDT.Utilities.EmailService;
using SSRNMFSSN.Repository;
using SSRNMFSSN.Domain;
using Core.Repository.Interfaces;

namespace Api
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
            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.Configure<SSRNMGlobal>(Configuration.GetSection("Paths"));
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = "ClientCertificateAuthentication";
            })
            .AddDrtAuthentication()
            .AddClientCertificateAuthentication(options =>
                ClientCertificateAuthenticationOptions.CreateForOnlyDoDRoots());

            MapperFactory.Init();
            services.AddAutoMapper(typeof(DtoMappingProfile));



            services.AddControllers();
            services.AddHttpContextAccessor();



            services.AddDbContext<SSRNMFSSNContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<DbContext>();
            services.AddScoped<SSRNMFSSNContext>();
            services.AddScoped<ReportRepository>();
            services.AddScoped<ReportDomain>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<UserDomain>();
            //services.AddDataProtection();


            services.AddTransient<EmailService>(options =>
            {
                EmailServiceOptions eoptions = new EmailServiceOptions();
                Configuration.GetSection("EmailService").Bind(eoptions);
                var emailService = new EmailService(eoptions);
                return emailService;
            });



        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseHttpsRedirection();
            //app.UseMvc();
        }
    }
}
