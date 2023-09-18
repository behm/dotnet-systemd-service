using OrderProcessor;

var builder = Host.CreateApplicationBuilder(args);

// todo: somewhere the UseSystemd() method needs to be called, but where?!?!?

builder.Services.AddHostedService<Worker>();
builder.Services.AddHostedService<AnotherWorker>();

var host = builder.Build();
host.Run();
