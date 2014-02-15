using AutoMapper;
using AutoMapperValueResolver.Models;
using System;

namespace AutoMapperValueResolver.Resolver
{
    public class FullNameResolver : ValueResolver<Client, string>
    {
        protected override string ResolveCore(Client source)
        {
            return string.Format("{0} {1}",source.Name, source.LastName);
        }
    }
}