using GraphQL.Data;
using GraphQL.Extensions;
using GraphQL.GraphQL;
using GraphQL.GraphQL.Categories;
using GraphQL.GraphQL.Coupons;
using GraphQL.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);





builder.Services.AddAutoMapper(typeof(Program));

builder.Services.RunServices(builder.Configuration);



var app = builder.Build();


app.UseWebSockets();

app.UseRouting();
app.UseEndpoints(endPoints =>
{
    endPoints.MapGraphQL();
});


app.Run();
