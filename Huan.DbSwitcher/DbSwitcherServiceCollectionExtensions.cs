using Huan.DbSwitcher.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Huan.DbSwitcher
{
    public static class DbSwitcherServiceCollectionExtensions
    {
        /// <summary>
        /// 添加FreeSql支持
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddDbSwitcher(this IServiceCollection services)
        {
            services.TryAddTransient(typeof(IDynamicChangeRepository<,>), typeof(DynamicChangeRepository<,>));
            return services;
        }
    }
}