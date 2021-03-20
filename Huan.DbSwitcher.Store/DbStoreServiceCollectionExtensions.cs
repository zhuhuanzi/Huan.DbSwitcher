using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Huan.DbSwitcher.Store.Partition;

namespace Huan.DbSwitcher.Store
{
    public static class DbStoreServiceCollectionExtensions
    {

        /// <summary>
        /// 添加仓储服务
        /// </summary>
        /// <param name="services"></param>

        /// <returns></returns>
        public static IServiceCollection AddDbStorage(
            this IServiceCollection services
        )
        {


            services.TryAddSingleton<IPartitionTableNameFactory, PartitionTableNameFactory>();


            return services;

        }

    }
}