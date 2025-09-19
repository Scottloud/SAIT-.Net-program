using FinalOOProject.Services;

namespace FinalOOProject;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		
		var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"LibraryManager.db3");
    
		builder.Services.AddSingleton<StaffService>(p => ActivatorUtilities.CreateInstance<StaffService>(p, dbPath));
		builder.Services.AddSingleton<BookService>(p => ActivatorUtilities.CreateInstance<BookService>(p, dbPath));
		builder.Services.AddSingleton<CustomerService>(p => ActivatorUtilities.CreateInstance<CustomerService>(p, dbPath));


		return builder.Build();
	}
}
