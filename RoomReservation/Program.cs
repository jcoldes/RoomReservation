using AutoMapper;
using RoomReservation.Config;
using RoomReservation.Databases;
using RoomReservation.Respositories;
using RoomReservation.Respositories.Interfaces;
using RoomReservation.Services;
using RoomReservation.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddMvc();
builder.Services.AddDbContext<RoomReservationContext>();

builder.Services.AddScoped(typeof(IUserService), typeof(UserService));
builder.Services.AddScoped(typeof(IRoomService), typeof(RoomService));
builder.Services.AddScoped(typeof(IMeetingService), typeof(MeetingService));
builder.Services.AddScoped(typeof(ILocationService), typeof(LocationService));

builder.Services.AddTransient(typeof(IUserRepository), typeof(UserRepository));
builder.Services.AddTransient(typeof(IRoomRepository), typeof(RoomRepository));
builder.Services.AddTransient(typeof(IMeetingRepository), typeof(MeetingRepository));
builder.Services.AddTransient(typeof(ILocationRepository), typeof(LocationRepository));


var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new AutoMapperProfile());
});

var mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
