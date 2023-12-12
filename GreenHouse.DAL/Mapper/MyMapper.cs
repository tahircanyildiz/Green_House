﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EfDeneme.DAL.Mapper
{
    public class MyMapper<TFrom, TTo>
    {


        public TTo Map(TFrom source)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TFrom, TTo>().ReverseMap();
            });

            var mapper = config.CreateMapper();
            return mapper.Map<TTo>(source);
        }
    }
}