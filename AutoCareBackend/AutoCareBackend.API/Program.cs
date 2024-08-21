using AutoCareBackend.Repo;
using AutoCareBackend.Repo.Interfaces;
using AutoCareBackend.Repo.Repositories;
using AutoCareBackend.Service.Interfaces;
using AutoCareBackend.Service.Services;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;

namespace AutoCareBackend.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Firebase DI
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "./firebase/autocare-firebase.json");
            builder.Services.AddScoped<IFirestoreDB, FirestoreDB>();

            builder.Services.AddSingleton(provider =>{
                return FirestoreDb.Create("autocare-a87a3");
            });
            // builder.Services.Add
            // Add services to the container.

            //All the nesseary DI here
            builder.Services.AddScoped<IUserRepo, UserRepo>(); 
            builder.Services.AddScoped<IUserService, UserServie>();


            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
