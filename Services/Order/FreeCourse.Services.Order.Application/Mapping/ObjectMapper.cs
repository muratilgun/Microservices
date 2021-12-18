using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace FreeCourse.Services.Order.Application.Mapping
{
    public class ObjectMapper
    {
        //lazy loading için yani sadece istenildiği zaman initialize etmek istiyorum.
        private static readonly Lazy<IMapper> lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CustomMapping>();
            });
            return config.CreateMapper();
        });
    }
}
