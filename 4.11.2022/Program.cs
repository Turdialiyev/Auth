using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
       .AddJwtBearer(jwtopton =>
       {

           jwtopton.TokenValidationParameters = new TokenValidationParameters()
           {
               ValidateIssuer = true,
               ValidIssuer = "Project1",
               ValidateAudience = true,
               ValidAudience = "Project",
               ValidateIssuerSigningKey = true,
               IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("sasfdfffffffffffffffffffffadasdqw3884nfojdaklmo08-"))
           };
       });
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
