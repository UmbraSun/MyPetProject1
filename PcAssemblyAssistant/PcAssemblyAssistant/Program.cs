using PcAssemblyAssistant.Extensions;
using PcAssemblyAssistant.Extentions;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration; // allows both to access and to set up the config
IWebHostEnvironment environment = builder.Environment;

// Add services to the container.
builder.Services.AddServiceExt(configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
await app.PipelineExt();

app.Run();
