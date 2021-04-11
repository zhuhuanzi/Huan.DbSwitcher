# Huan.DbSwitcher
Huan.DbSwitcher,such as NoSQL(MongoDB) or SQL(Oracle、SqlServer) to CRUD,support split database and split table.


## LICENSES

![GitHub](https://img.shields.io/github/license/zhuhuanzi/Huan.DbSwitcher)
[![Badge](https://img.shields.io/badge/link-996.icu-%23FF4D5B.svg?style=flat-square)](https://996.icu/#/zh_CN)
[![LICENSE](https://img.shields.io/badge/license-Anti%20996-blue.svg?style=flat-square)](https://github.com/996icu/996.ICU/blob/master/LICENSE)

Please note: once the use of the open source projects as well as the reference for the project or containing the project code for violating labor laws (including but not limited the illegal layoffs, overtime labor, child labor, etc.) in any legal action against the project, the author has the right to punish the project fee, or directly are not allowed to use any contains the source code of this project!




## Nuget Packages
| Package         | Status     |
| --------------- | ---------- |
| Huan.DbSwitcher | [![Nuget](https://img.shields.io/badge/nuget-v0.1.0--bate-green)](https://www.nuget.org/packages/Huan.DbSwitcher/0.1.0-bate#) |



## Demos

#### Installation package

```
Install-Package Huan.DbSwitcher -Version 0.1.0-bate
```

#### Register

```c#
public IServiceProvider ConfigureServices(IServiceCollection services)
{
    
    		services.AddDbSwitcher();
    
            services.AddMongoDbStore(new MongoDbSetting()
            {
                Name = "DefaultMongoDb",
                ConnectionString = "mongodb://admin:admin123@127.0.0.1:27017/HuanDbSwitcher",
                DatabaseName = "HuanDbSwitcher",
            });
    		
    		services.AddFreeSqlDbStore(new FSqlSetting(){
                Name="DefaultFreesql",
                ConnectionString="Server=127.0.0.1,1433;Database=HuanDbSwitcher;User Id=sa;Password=admin123;",
                DatabaseType = DatabaseType.SqlServer
            });
}    

```

#### Use

```C#
public class Demo
{
    readonly IDynamicChangeRepository<DemoEntity, string> _iDynamicChangeRepository;
    public Demo(IDynamicChangeRepository<DemoEntity, string> iDynamicChangeRepository)
    {
        _iDynamicChangeRepository = iDynamicChangeRepository;
    }

    public void Examples()
    {
        //ChangeProvider,Default is sql,If you want  change to nosql,please use ChangeProvider.
        //_iDynamicChangeRepository.ChangeProvider("DefaultMongoDb", DatabaseType.MongoDB);

        //Query
        //_iDynamicChangeRepository.GetQuery().Where(x => x.Id = "1");

        //Insert
        //_iDynamicChangeRepository.Insert(...);

        //Update
        //_iDynamicChangeRepository.Update(...);

        //Delete
        //_iDynamicChangeRepository.Delete(...);

        //UnitOfWork
        //_iDynamicChangeRepository.BeginUnitOfWork();
    }
}
```







## Q&A
If you have any questions, you can go to  [Issues](https://github.com/zhuhuanzi/Huan.DbSwitcher/issues)  to ask them.

## Reference project

> This project directly or indirectly refers to the following items

- [ABP](https://github.com/aspnetboilerplate/aspnetboilerplate)
- [RivenFx](https://github.com/rivenfx)
- [FreeSQL](https://github.com/dotnetcore/FreeSql)
- [SqlSugar](https://github.com/donet5/SqlSugar)
- [MongoDB.Driver](https://github.com/mongodb/mongo-csharp-driver)



