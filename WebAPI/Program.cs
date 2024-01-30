using PersonalBlog.Entities.Dtos.Accounts;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Service.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Service.Concrete;
using System;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(x => {
    x.IOTimeout = TimeSpan.FromSeconds(1);//kullanıcı 1 dk içerisinde giriş yapmazsa hata çevirir.  
    x.IdleTimeout = TimeSpan.FromSeconds(10);// kullanıcı 10 dk boyunca boş kalırsa sistem sonşlanır.
    x.Cookie.HttpOnly= true;//javascrit yazarak cookyden sunucuya er,şemesin
    x.Cookie.IsEssential= true;// tarayıcının cerezlerimizi engelleyemeyeceği ve her durumda gözükeceğini söylüyoruz.
});
// Servis bağımlılıklarını ekleyin
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<IContactService, ContactService>();
builder.Services.AddScoped<IEducationService, EducationService>();
builder.Services.AddScoped<IExperiencesService, ExperiencesService>();
builder.Services.AddScoped<IInterestedService, InterestedService>();
builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddScoped<ISiteIdentityService, SiteIdentityService>();
builder.Services.AddScoped<ISkillsService, SkillsService>();
builder.Services.AddScoped<ISliderService, SliderService>();


builder.Services.ConfigureApplicationCookie(config =>
{
   
    config.Cookie = new CookieBuilder
    {
        Name = "PersonalBlog",
        HttpOnly = true,
        SameSite = SameSiteMode.Strict,
        SecurePolicy = CookieSecurePolicy.SameAsRequest//http v https den istek atabiliriz canlýda sonu Always olmalý
    };
    config.SlidingExpiration = true;
    config.ExpireTimeSpan = TimeSpan.FromDays(7);//7 gün boyunca sitede oturum açmýþ kalacaksýn
    
});

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.UseSession();// eklediğimiz sessionları kullanmamız gerekiyot . bu .net özelliği bu kodu yazmasam sesionlar kullanılmaz.
app.MapControllers();

app.Run();
