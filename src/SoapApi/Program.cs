using CoreWCF;
using CoreWCF.Configuration;
using CoreWCF.Description;
using SoapApi.ServiceContract;
using SoapApi.Services;

var builder = WebApplication.CreateBuilder();
builder.Services.AddServiceModelServices();
builder.Services.AddServiceModelMetadata();
var app = builder.Build();
app.UseServiceModel(bld =>
{
    bld.AddService<CalculatorService>();
    bld.AddServiceEndpoint<CalculatorService, ICalculatorService>(
        new BasicHttpBinding(),
        "/calculation.svc");
    
    var mb = app.Services.GetRequiredService<ServiceMetadataBehavior>();
    mb.HttpsGetEnabled = true;
});
app.Run();