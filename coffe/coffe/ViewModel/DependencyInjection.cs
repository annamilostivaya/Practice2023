using coffe.NavigationServises;
using coffe.Stores;
using Microsoft.Extensions.DependencyInjection;
using System;



namespace coffe.ViewModel
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddViewsModels(this IServiceCollection services)
        {

            services.AddSingleton<NavigationStore>();
            services.AddSingleton<MainViewModel>();


            services.AddSingleton<AccountVM>();
            services.AddSingleton<NavigationService<AccountVM>>();
            services.AddSingleton<Func<AccountVM>>((s) => () => s.GetRequiredService<AccountVM>());

            services.AddSingleton<AddingItemsVM>();
            services.AddSingleton<NavigationService<AddingItemsVM>>();
            services.AddSingleton<Func<AddingItemsVM>>((s) => () => s.GetRequiredService<AddingItemsVM>());


            services.AddTransient<AdminView>();
            services.AddSingleton<Func<AdminView>>((s) => () => s.GetRequiredService<AdminView>());
            services.AddSingleton<NavigationService<AdminView>>();

            services.AddTransient<AuthorizationVM>();
            services.AddSingleton<Func<AuthorizationVM>>((s) => () => s.GetRequiredService<AuthorizationVM>());
            services.AddSingleton<NavigationService<AuthorizationVM>>();



            services.AddTransient<ItemsVM>();
            services.AddSingleton<Func<ItemsVM>>((s) => () => s.GetRequiredService<ItemsVM>());
            services.AddSingleton<NavigationService<ItemsVM>>();

            services.AddTransient<OrdersVM>();
            services.AddSingleton<Func<OrdersVM>>((s) => () => s.GetRequiredService<OrdersVM>());
            services.AddSingleton<NavigationService<OrdersVM>>();

            services.AddTransient<RegistrationVM>();
            services.AddSingleton<Func<RegistrationVM>>((s) => () => s.GetRequiredService<RegistrationVM>());
            services.AddSingleton<NavigationService<RegistrationVM>>();

       

            return services;
        }



    }
}
